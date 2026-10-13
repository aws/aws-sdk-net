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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeSpace operation.
    /// </summary>
    public partial class DescribeSpaceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the associated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystemUid. 
        /// <para>
        /// The ID of the space's profile in the Amazon EFS volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string HomeEfsFileSystemUid { get; set; }

        /// <summary>
        /// Checks to see if the HomeEfsFileSystemUid property is set.
        /// </summary>
        internal bool IsSetHomeEfsFileSystemUid() => this.HomeEfsFileSystemUid != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnershipSettings. 
        /// <para>
        /// The collection of ownership settings for a space.
        /// </para>
        /// </summary>
        public OwnershipSettings OwnershipSettings { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipSettings property is set.
        /// </summary>
        internal bool IsSetOwnershipSettings() => this.OwnershipSettings != null;

        /// <summary>
        /// Gets and sets the property SpaceArn. 
        /// <para>
        /// The space's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SpaceArn { get; set; }

        /// <summary>
        /// Checks to see if the SpaceArn property is set.
        /// </summary>
        internal bool IsSetSpaceArn() => this.SpaceArn != null;

        /// <summary>
        /// Gets and sets the property SpaceDisplayName. 
        /// <para>
        /// The name of the space that appears in the Amazon SageMaker Studio UI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string SpaceDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceDisplayName property is set.
        /// </summary>
        internal bool IsSetSpaceDisplayName() => this.SpaceDisplayName != null;

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property SpaceSettings. 
        /// <para>
        /// A collection of space settings.
        /// </para>
        /// </summary>
        public SpaceSettings SpaceSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSettings property is set.
        /// </summary>
        internal bool IsSetSpaceSettings() => this.SpaceSettings != null;

        /// <summary>
        /// Gets and sets the property SpaceSharingSettings. 
        /// <para>
        /// The collection of space sharing settings for a space.
        /// </para>
        /// </summary>
        public SpaceSharingSettings SpaceSharingSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceSharingSettings property is set.
        /// </summary>
        internal bool IsSetSpaceSharingSettings() => this.SpaceSharingSettings != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public SpaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// Returns the URL of the space. If the space is created with Amazon Web Services IAM
        /// Identity Center (Successor to Amazon Web Services Single Sign-On) authentication,
        /// users can navigate to the URL after appending the respective redirect parameter for
        /// the application type to be federated through Amazon Web Services IAM Identity Center.
        /// </para>
        ///  
        /// <para>
        /// The following application types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Studio Classic: <c>&amp;redirect=JupyterServer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JupyterLab: <c>&amp;redirect=JupyterLab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Code Editor, based on Code-OSS, Visual Studio Code - Open Source: <c>&amp;redirect=CodeEditor</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
