namespace GenericSouls
{
    interface IMyStack<T>: IPrintable
    {
        void Push(T toPushValue);
        T Pop();
        T Peek();

    }
}
