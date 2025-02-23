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
    /// Container for the parameters to the ModifyInstanceMetadataDefaults operation.
    /// Modifies the default instance metadata service (IMDS) settings at the account level
    /// in the specified Amazon Web Services&#x2028; Region.
    /// 
    ///  <note> 
    /// <para>
    /// To remove a parameter's account-level default setting, specify <c>no-preference</c>.
    /// If an account-level setting is cleared with <c>no-preference</c>, then the instance
    /// launch considers the other instance metadata settings. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html#instance-metadata-options-order-of-precedence">Order
    /// of precedence for instance metadata options</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyInstanceMetadataDefaultsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private DefaultInstanceMetadataEndpointState _httpEndpoint;
        private int? _httpPutResponseHopLimit;
        private MetadataDefaultHttpTokensState _httpTokens;
        private DefaultInstanceMetadataTagsState _instanceMetadataTags;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Enables or disables the IMDS endpoint on an instance. When disabled, the instance
        /// metadata can't be accessed.
        /// </para>
        /// </summary>
        public DefaultInstanceMetadataEndpointState HttpEndpoint
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
        /// The maximum number of hops that the metadata token can travel. To indicate no preference,
        /// specify <c>-1</c>.
        /// </para>
        ///  
        /// <para>
        /// Possible values: Integers from <c>1</c> to <c>64</c>, and <c>-1</c> to indicate no
        /// preference
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
        public MetadataDefaultHttpTokensState HttpTokens
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
        /// Enables or disables access to an instance's tags from the instance metadata. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#work-with-tags-in-IMDS">Work
        /// with instance tags using the instance metadata</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public DefaultInstanceMetadataTagsState InstanceMetadataTags
        {
            get { return this._instanceMetadataTags; }
            set { this._instanceMetadataTags = value; }
        }

        // Check to see if InstanceMetadataTags property is set
        internal bool IsSetInstanceMetadataTags()
        {
            return this._instanceMetadataTags != null;
        }

    }
}