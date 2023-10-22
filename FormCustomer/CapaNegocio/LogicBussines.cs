using FormCustomer.CapaDatos;
using FormCustomer.CapaEntidad;
using System.Data;

namespace FormCustomer.CapaNegocio
{
    public class LogicBussines
    {
        private readonly Execute execute = new();
        public void AddDataCustomer(CustomerModel customer)
        {
            if (ValidatorDataRequired(customer))
            {
                execute.InsertCustomer(customer);

            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public DataTable UploadCustomerData()
        {
            return execute.GetAllCustomers();
        }

        public bool DeleteService(string id)
        {

            try
            {
                return execute.DeleteCustomer(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to delete the data ID: {id} {ex}");
            }

            return false;
        }

        public bool UpdateService(CustomerModel customer, string id)
        {
            try
            {
                return execute.UpdateCustomer(customer, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to update the data ID: {id} {ex}");
            }

            return false;
        }


        public bool ValidatorDataRequired(CustomerModel customer)
        {
            bool completeData = true;

            if (string.IsNullOrEmpty(customer.Name))
            {
                completeData = false;
                MessageBox.Show("The name is required data");
            }

            if (string.IsNullOrEmpty(customer.LastName))
            {
                completeData = false;
                MessageBox.Show("The LastName is required data");
            }

            if (string.IsNullOrEmpty(customer.Picture))
            {
                completeData = false;
                MessageBox.Show("The Picture is required data");
            }

            return completeData;
        }
    }
}
