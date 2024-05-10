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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateViewVersion operation.
    /// Publishes a new version of the view identifier.
    /// 
    ///  
    /// <para>
    /// Versions are immutable and monotonically increasing.
    /// </para>
    ///  
    /// <para>
    /// It returns the highest version if there is no change in content compared to that version.
    /// An error is displayed if the supplied ViewContentSha256 is different from the ViewContentSha256
    /// of the <c>$LATEST</c> alias.
    /// </para>
    /// </summary>
    public partial class CreateViewVersionRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _versionDescription;
        private string _viewContentSha256;
        private string _viewId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// The description for the version being published.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ViewContentSha256. 
        /// <para>
        /// Indicates the checksum value of the latest published view content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ViewContentSha256
        {
            get { return this._viewContentSha256; }
            set { this._viewContentSha256 = value; }
        }

        // Check to see if ViewContentSha256 property is set
        internal bool IsSetViewContentSha256()
        {
            return this._viewContentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property ViewId. 
        /// <para>
        /// The identifier of the view. Both <c>ViewArn</c> and <c>ViewId</c> can be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ViewId
        {
            get { return this._viewId; }
            set { this._viewId = value; }
        }

        // Check to see if ViewId property is set
        internal bool IsSetViewId()
        {
            return this._viewId != null;
        }

    }
}