/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserDefinedFunction operation.
    /// Updates an existing function definition in the Data Catalog.
    /// </summary>
    public partial class UpdateUserDefinedFunctionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private UserDefinedFunctionInput _functionInput;
        private string _functionName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the function to be updated is located. If none is
        /// supplied, the AWS account ID is used by default.
        /// </para>
        /// </summary>
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database where the function to be updated is located.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionInput. 
        /// <para>
        /// A <code>FunctionInput</code> object that re-defines the function in the Data Catalog.
        /// </para>
        /// </summary>
        public UserDefinedFunctionInput FunctionInput
        {
            get { return this._functionInput; }
            set { this._functionInput = value; }
        }

        // Check to see if FunctionInput property is set
        internal bool IsSetFunctionInput()
        {
            return this._functionInput != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

    }
}