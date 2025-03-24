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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
        private string _actionTraceId;
        private string _name;
        private Amazon.Runtime.Documents.Document _parameters;
        private string _ref;

        /// <summary>
        /// Gets and sets the property ActionTraceId. 
        /// <para>
        /// Describe a capability action with an <c>actionTraceId</c> for a response command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=20)]
        public string ActionTraceId
        {
            get { return this._actionTraceId; }
            set { this._actionTraceId = value; }
        }

        // Check to see if ActionTraceId property is set
        internal bool IsSetActionTraceId()
        {
            return this._actionTraceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Describe a capability action with a name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Describe a capability action with a capability property.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Amazon.Runtime.Documents.Document Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return !this._parameters.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Ref. 
        /// <para>
        /// Describe a capability action with an reference.
        /// </para>
        /// </summary>
        public string Ref
        {
            get { return this._ref; }
            set { this._ref = value; }
        }

        // Check to see if Ref property is set
        internal bool IsSetRef()
        {
            return this._ref != null;
        }

    }
}