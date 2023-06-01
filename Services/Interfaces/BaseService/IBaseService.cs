namespace Service.Services.Interfaces.BaseService
{
    public interface IBaseService<T>
    {
        public void Create(T entity); //Post
        public void Delete(T entity); //Delete
        public T GetById(int id); //Get
        public  Task<ICollection<T>> GetAll(); //Get
        //public T Update (T entity); //Put
    
    }
}
