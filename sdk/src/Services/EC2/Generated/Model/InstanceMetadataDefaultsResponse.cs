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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The default instance metadata service (IMDS) settings that were set at the account
    /// level in the specified Amazon Web Services&#x2028; Region.
    /// </summary>
    public partial class InstanceMetadataDefaultsResponse
    {
        private InstanceMetadataEndpointState _httpEndpoint;
        private int? _httpPutResponseHopLimit;
        private HttpTokensState _httpTokens;
        private InstanceMetadataTagsState _instanceMetadataTags;
        private ManagedBy _managedBy;
        private string _managedExceptionMessage;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Indicates whether the IMDS endpoint for an instance is enabled or disabled. When disabled,
        /// the instance metadata can't be accessed.
        /// </para>
        /// </summary>
        public InstanceMetadataEndpointState HttpEndpoint
        {
            get { return this._httpEndpoint; }
            set { this._httpEndpoint = value; }
        }

        // Check to see if HttpEndpoint property is set
        internal bool IsSetHttpEndpoint()
        {
            return this._httpEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The maximum number of hops that the metadata token can travel.
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit
        {
            get { return this._httpPutResponseHopLimit; }
            set { this._httpPutResponseHopLimit = value; }
        }

        // Check to see if HttpPutResponseHopLimit property is set
        internal bool IsSetHttpPutResponseHopLimit()
        {
            return this._httpPutResponseHopLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Indicates whether IMDSv2 is required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>optional</c> – IMDSv2 is optional, which means that you can use either IMDSv2
        /// or IMDSv1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>required</c> – IMDSv2 is required, which means that IMDSv1 is disabled, and you
        /// must use IMDSv2.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HttpTokensState HttpTokens
        {
            get { return this._httpTokens; }
            set { this._httpTokens = value; }
        }

        // Check to see if HttpTokens property is set
        internal bool IsSetHttpTokens()
        {
            return this._httpTokens != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMetadataTags. 
        /// <para>
        /// Indicates whether access to instance tags from the instance metadata is enabled or
        /// disabled. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#work-with-tags-in-IMDS">Work
        /// with instance tags using the instance metadata</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMetadataTagsState InstanceMetadataTags
        {
            get { return this._instanceMetadataTags; }
            set { this._instanceMetadataTags = value; }
        }

        // Check to see if InstanceMetadataTags property is set
        internal bool IsSetInstanceMetadataTags()
        {
            return this._instanceMetadataTags != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the IMDS default settings. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The IMDS default settings are managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The IMDS default settings are managed by a declarative
        /// policy and can't be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedExceptionMessage. 
        /// <para>
        /// The customized exception message that is specified in the declarative policy.
        /// </para>
        /// </summary>
        public string ManagedExceptionMessage
        {
            get { return this._managedExceptionMessage; }
            set { this._managedExceptionMessage = value; }
        }

        // Check to see if ManagedExceptionMessage property is set
        internal bool IsSetManagedExceptionMessage()
        {
            return this._managedExceptionMessage != null;
        }

    }
}