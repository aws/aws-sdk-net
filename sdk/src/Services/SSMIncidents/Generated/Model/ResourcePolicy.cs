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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The resource policy that allows Incident Manager to perform actions on resources on
    /// your behalf.
    /// </summary>
    public partial class ResourcePolicy
    {
        private string _policyDocument;
        private string _policyId;
        private string _ramResourceShareRegion;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON blob that describes the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4000)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the resource policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property RamResourceShareRegion. 
        /// <para>
        /// The Amazon Web Services Region that policy allows resources to be used in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RamResourceShareRegion
        {
            get { return this._ramResourceShareRegion; }
            set { this._ramResourceShareRegion = value; }
        }

        // Check to see if RamResourceShareRegion property is set
        internal bool IsSetRamResourceShareRegion()
        {
            return this._ramResourceShareRegion != null;
        }

    }
}