/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context interface for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    partial interface IDynamoDBContext : IDisposable
    {
        #region Save/serialize

        /// <summary>
        /// Serializes an object to a Document.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <returns>Document with attributes populated from object.</returns>
        Document ToDocument<T>(T value);

        #endregion

        #region Load/deserialize

        /// <summary>
        /// Deserializes a document to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document">Document with properties to use.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        T FromDocument<T>(Document document);

        #endregion

    }
}
