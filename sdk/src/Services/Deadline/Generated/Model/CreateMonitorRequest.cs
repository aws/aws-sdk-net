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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMonitor operation.
    /// Creates an Amazon Web Services Deadline Cloud monitor that you can use to view your
    /// farms, queues, and fleets. After you submit a job, you can track the progress of the
    /// tasks and steps that make up the job, and then download the job's results.
    /// </summary>
    public partial class CreateMonitorRequest : AmazonDeadlineRequest
    {
        private string _clientToken;
        private string _displayName;
        private string _identityCenterInstanceArn;
        private string _roleArn;
        private string _subdomain;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name that you give the monitor that is displayed in the Deadline Cloud console.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance that authenticates
        /// monitor users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the monitor uses to connect to
        /// Deadline Cloud. Every user that signs in to the monitor using IAM Identity Center
        /// uses this role to access Deadline Cloud resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdomain. 
        /// <para>
        /// The subdomain to use when creating the monitor URL. The full URL of the monitor is
        /// subdomain.Region.deadlinecloud.amazonaws.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Subdomain
        {
            get { return this._subdomain; }
            set { this._subdomain = value; }
        }

        // Check to see if Subdomain property is set
        internal bool IsSetSubdomain()
        {
            return this._subdomain != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to your monitor. Each tag consists of a tag key and a tag value. Tag
        /// keys and values are both required, but tag values can be empty strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}