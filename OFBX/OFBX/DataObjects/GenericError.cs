namespace OFBX.DataObjects
{
    public class GenericError
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public GenericError(int ErrorCode, string ErrorMessage)
        {
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
        }
    }
}
