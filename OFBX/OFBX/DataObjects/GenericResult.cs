namespace OFBX.DataObjects
{
    public class GenericResult<T>
    {
        public T Result { get; set; }
        public GenericError Error { get; set; }

        public GenericResult(GenericError error,T t)
        {
            this.Result = t;
            this.Error = error;
        }public GenericResult(T t)
        {
            this.Result = t;
        }
        public GenericResult()
        {

        }
    }
}
