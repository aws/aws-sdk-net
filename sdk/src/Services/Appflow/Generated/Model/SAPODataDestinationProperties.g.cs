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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when using SAPOData as a flow destination
    /// </summary>
    public partial class SAPODataDestinationProperties
    {
        /// <summary>
        /// Gets and sets the property ErrorHandlingConfig.
        /// </summary>
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ErrorHandlingConfig property is set.
        /// </summary>
        internal bool IsSetErrorHandlingConfig() => this.ErrorHandlingConfig != null;

        /// <summary>
        /// Gets and sets the property IdFieldNames.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<string> IdFieldNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IdFieldNames property is set.
        /// </summary>
        internal bool IsSetIdFieldNames() => this.IdFieldNames != null && (this.IdFieldNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectPath. 
        /// <para>
        /// The object path specified in the SAPOData flow destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// Checks to see if the ObjectPath property is set.
        /// </summary>
        internal bool IsSetObjectPath() => this.ObjectPath != null;

        /// <summary>
        /// Gets and sets the property SuccessResponseHandlingConfig. 
        /// <para>
        /// Determines how Amazon AppFlow handles the success response that it gets from the connector
        /// after placing data.
        /// </para>
        ///  
        /// <para>
        /// For example, this setting would determine where to write the response from a destination
        /// connector upon a successful insert operation.
        /// </para>
        /// </summary>
        public SuccessResponseHandlingConfig SuccessResponseHandlingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SuccessResponseHandlingConfig property is set.
        /// </summary>
        internal bool IsSetSuccessResponseHandlingConfig() => this.SuccessResponseHandlingConfig != null;

        /// <summary>
        /// Gets and sets the property WriteOperationType.
        /// </summary>
        public WriteOperationType WriteOperationType { get; set; }

        /// <summary>
        /// Checks to see if the WriteOperationType property is set.
        /// </summary>
        internal bool IsSetWriteOperationType() => this.WriteOperationType != null;
    }
}
