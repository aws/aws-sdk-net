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
    /// Action for an Amazon Web Services capability, containing the action parameters for
    /// control.
    /// </summary>
    public partial class CapabilityAction
    {
        /// <summary>
        /// Gets and sets the property ActionTraceId. 
        /// <para>
        /// Describe a capability action with an <c>actionTraceId</c> for a response command.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 20)]
        public string ActionTraceId { get; set; }

        /// <summary>
        /// Checks to see if the ActionTraceId property is set.
        /// </summary>
        internal bool IsSetActionTraceId() => this.ActionTraceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Describe a capability action with a name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Describe a capability action with a capability property.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => !this.Parameters.IsNull();

        /// <summary>
        /// Gets and sets the property Ref. 
        /// <para>
        /// Describe a capability action with an reference.
        /// </para>
        /// </summary>
        public string Ref { get; set; }

        /// <summary>
        /// Checks to see if the Ref property is set.
        /// </summary>
        internal bool IsSetRef() => this.Ref != null;
    }
}
