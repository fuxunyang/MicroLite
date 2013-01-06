﻿// -----------------------------------------------------------------------
// <copyright file="IdentifierStrategy.cs" company="MicroLite">
// Copyright 2012 Trevor Pilley
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Mapping
{
    /// <summary>
    /// The supported types of strategy used to manage a row identifier.
    /// </summary>
    public enum IdentifierStrategy
    {
        /// <summary>
        /// The identifier value is generated by the database upon insert by an identity column in MsSql.
        /// </summary>
        [System.Obsolete("The Identity strategy has been superceeded by DbGenerated, please use that instead.", error: true)]
        Identity = 0,

        /// <summary>
        /// The identifier value is generated by the database upon insert (for example Identity in MsSQL or AutoIncrement in SQLite, MySQL or PostgreSQL).
        /// </summary>
        DbGenerated = 0,

        /// <summary>
        /// The identifier value is assigned by user code prior to insert.
        /// </summary>
        Assigned = 1,

        /// <summary>
        /// The identifier is automatically assigned a new System.Guid as it's value prior to insert.
        /// </summary>
        /// <remarks>This uses the static method Guid.NewGuid() to generate the GUID.</remarks>
        Guid = 2,

        /// <summary>
        /// The identifier is automatically assigned a new combed System.Guid as it's value prior to insert.
        /// </summary>
        /// <remarks>This uses custom code to ensure that the Guid is unique but also reduces index fragmentation in the database.</remarks>
        GuidComb = 3,

        /// <summary>
        /// The identifier value is generated by the database upon insert by an auto increment column in SQLite.
        /// </summary>
        [System.Obsolete("The AutoIncrement strategy has been superceeded by DbGenerated, please use that instead.", error: true)]
        AutoIncrement = 4
    }
}