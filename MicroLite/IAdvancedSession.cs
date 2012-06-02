﻿namespace MicroLite
{
    using System;

    /// <summary>
    /// The interface which provides access to advanced operations.
    /// </summary>
    /// <remarks>
    /// These operations allow for more advanded use and have been moved to a separate property to avoid
    /// cluttering the ISession API.
    /// </remarks>
    public interface IAdvancedSession : IHideObjectMembers
    {
        /// <summary>
        /// Deletes the database record for the type with the supplied identifier.
        /// </summary>
        /// <param name="type">The type to delete.</param>
        /// <param name="identifier">The identifier of the record to delete.</param>
        /// <returns>true if the object was deleted successfully; otherwise false.</returns>
        /// <exception cref="ObjectDisposedException">Thrown if session has been disposed.</exception>
        /// <exception cref="ArgumentNullException">Thrown if supplied identifier is null.</exception>
        /// <exception cref="MicroLiteException">Thrown if there is an error executing the delete command.</exception>
        bool Delete(Type type, object identifier);

        /// <summary>
        /// Executes the specified SQL query.
        /// </summary>
        /// <param name="sqlQuery">The SQL query to execute.</param>
        /// <returns>The number of rows affected by the sql query.</returns>
        int Execute(SqlQuery sqlQuery);

        /// <summary>
        /// Executes the supplied SQL query as a scalar command.
        /// </summary>
        /// <typeparam name="T">The type of result to be returned.</typeparam>
        /// <param name="sqlQuery">The SQL query to execute.</param>
        /// <returns>The result of the scalar query.</returns>
        T ExecuteScalar<T>(SqlQuery sqlQuery);
    }
}