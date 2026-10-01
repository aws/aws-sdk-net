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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// State capabilities added for the managed thing.
    /// </summary>
    public partial class StateCapability
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the managed thing in the capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the Amazon Web Services capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Describe the command capability with the properties it supports.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => !this.Properties.IsNull();

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version for the Amazon Web Services capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
