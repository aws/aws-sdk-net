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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAppBlockBuilder operation. Updates an app
    /// block builder. <para> If the app block builder is in the <c>STARTING</c> or <c>STOPPING</c>
    /// state, you can't update it. If the app block builder is in the <c>RUNNING</c> state,
    /// you can only update the DisplayName and Description. If the app block builder is in
    /// the <c>STOPPED</c> state, you can update any attribute except the Name. </para>
    /// </summary>
    public partial class UpdateAppBlockBuilderRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of interface VPC endpoint (interface endpoint) objects. Administrators can
        /// connect to the app block builder only through the specified endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<AccessEndpoint> AccessEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;

        /// <summary>
        /// Checks to see if the AccessEndpoints property is set.
        /// </summary>
        internal bool IsSetAccessEndpoints() => this.AccessEndpoints != null && (this.AccessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributesToDelete. 
        /// <para>
        /// The attributes to delete from the app block builder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesToDelete property is set.
        /// </summary>
        internal bool IsSetAttributesToDelete() => this.AttributesToDelete != null && (this.AttributesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableIMDSV1. 
        /// <para>
        /// Set to true to disable Instance Metadata Service Version 1 (IMDSv1) and enforce IMDSv2.
        /// Set to false to enable both IMDSv1 and IMDSv2.
        /// </para>
        /// </summary>
        public bool? DisableIMDSV1 { get; set; }

        /// <summary>
        /// Checks to see if the DisableIMDSV1 property is set.
        /// </summary>
        internal bool IsSetDisableIMDSV1() => this.DisableIMDSV1.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnableDefaultInternetAccess. 
        /// <para>
        /// Enables or disables default internet access for the app block builder.
        /// </para>
        /// </summary>
        public bool? EnableDefaultInternetAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnableDefaultInternetAccess property is set.
        /// </summary>
        internal bool IsSetEnableDefaultInternetAccess() => this.EnableDefaultInternetAccess.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to apply to the app block builder.
        /// To assume a role, the app block builder calls the AWS Security Token Service (STS)
        /// <c>AssumeRole</c> API operation and passes the ARN of the role to use. The operation
        /// creates a new session with temporary credentials. WorkSpaces Applications retrieves
        /// the temporary credentials and creates the <b>appstream_machine_role</b> credential
        /// profile on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/using-iam-roles-to-grant-permissions-to-applications-scripts-streaming-instances.html">Using
        /// an IAM Role to Grant Permissions to Applications and Scripts Running on WorkSpaces
        /// Applications Streaming Instances</a> in the <i>Amazon WorkSpaces Applications Administration
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use when launching the app block builder. The following instance
        /// types are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// stream.standard.small
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.2xlarge
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name for the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the app block builder.
        /// </para>
        ///  
        /// <para>
        ///  <c>WINDOWS_SERVER_2019</c> is the only valid value.
        /// </para>
        /// </summary>
        public PlatformType Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the app block builder.
        /// </para>
        ///  
        /// <para>
        /// App block builders require that you specify at least two subnets in different availability
        /// zones.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
