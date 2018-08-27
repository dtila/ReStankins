using System;
using System.Collections.Generic;
using System.Text;

namespace ReStankins
{
    #region Source

    public interface ISource
    {
        void AppendTo(ITransformation transformer);
    }

    #endregion

    /// <summary>
    /// A transformation operation that is altering the input data as unit of work
    /// </summary>
    /// <remarks>
    /// See <see cref="ITransformation"/> as a business operation that can be performed to a set of data. Some operations may require accessing multiple sets of 
    /// <see cref="ISource"/> while this could make sense to perform. For this <see cref="IDisposable"/> is made to be implemented, even an operation should teoretically access 
    /// only managed data
    /// </remarks>
    public interface ITransformation : IDisposable
    {
        //void ApplyTo(ISource source); //is really needed?
        void ApplyTo(Table table);
        void ApplyTo(Tree tree);
    }

    public interface IFilter : ITransformation
    {
        // maybe an expression tree?!?
    }

    
    public interface IOutputer : ITransformation
    {
        // a stream to write to?
    }
}
