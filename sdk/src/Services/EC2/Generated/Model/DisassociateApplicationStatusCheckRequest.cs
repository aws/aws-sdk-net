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
    /// Container for the parameters to the DisassociateApplicationStatusCheck operation.
    /// Disassociates an application status check from instances or <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">tags</a>.
    /// After disassociation, health monitoring stops for the affected instances. The following
    /// rules apply:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You must specify either <c>TargetTagAssociations</c> or <c>InstanceIds</c>, but not
    /// both. Specifying both results in an <c>InvalidParameterCombination</c> error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The application status check must already exist and belong to your account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tag keys must not be blank.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateApplicationStatusCheckRequest : AmazonEC2Request
    {
        private string _applicationStatusCheckId;
        private string _clientToken;
        private bool? _dryRun;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CustomTagKeyValueRequestPair> _targetTagAssociations = AWSConfigs.InitializeCollections ? new List<CustomTagKeyValueRequestPair>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check to disassociate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationStatusCheckId
        {
            get { return this._applicationStatusCheckId; }
            set { this._applicationStatusCheckId = value; }
        }

        // Check to see if ApplicationStatusCheckId property is set
        internal bool IsSetApplicationStatusCheckId()
        {
            return this._applicationStatusCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry a request with the same token, the service
        /// ignores the request but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances to disassociate from the application status check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTagAssociations. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">tags</a>
        /// to disassociate from the application status check. Specify the same key-value pairs
        /// that were used during association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomTagKeyValueRequestPair> TargetTagAssociations
        {
            get { return this._targetTagAssociations; }
            set { this._targetTagAssociations = value; }
        }

        // Check to see if TargetTagAssociations property is set
        internal bool IsSetTargetTagAssociations()
        {
            return this._targetTagAssociations != null && (this._targetTagAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}