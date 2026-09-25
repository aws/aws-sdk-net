/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the data type configuration for the data source associated with a form.
    /// </summary>
    public partial class FormDataTypeConfig
    {
        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The data source type, either an Amplify DataStore model or a custom data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FormDataSourceType DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property DataTypeName. 
        /// <para>
        /// The unique name of the data type you are using as the data source for the form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataTypeName { get; set; }

        /// <summary>
        /// Checks to see if the DataTypeName property is set.
        /// </summary>
        internal bool IsSetDataTypeName() => this.DataTypeName != null;
    }
}
