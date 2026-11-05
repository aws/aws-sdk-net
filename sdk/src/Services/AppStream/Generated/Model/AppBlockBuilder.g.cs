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
    /// Describes an app block builder.
    /// </summary>
    public partial class AppBlockBuilder
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
        /// Gets and sets the property AppBlockBuilderErrors. 
        /// <para>
        /// The app block builder errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceError> AppBlockBuilderErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;

        /// <summary>
        /// Checks to see if the AppBlockBuilderErrors property is set.
        /// </summary>
        internal bool IsSetAppBlockBuilderErrors() => this.AppBlockBuilderErrors != null && (this.AppBlockBuilderErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation time of the app block builder.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableIMDSV1. 
        /// <para>
        /// Indicates whether Instance Metadata Service Version 1 (IMDSv1) is disabled for the
        /// app block builder.
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
        [AWSProperty(Min = 1)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EnableDefaultInternetAccess. 
        /// <para>
        /// Indicates whether default internet access is enabled for the app block builder.
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
        /// The ARN of the IAM role that is applied to the app block builder.
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
        /// The instance type of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
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
        [AWSProperty(Required = true)]
        public AppBlockBuilderPlatformType Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppBlockBuilderState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The state change reason.
        /// </para>
        /// </summary>
        public AppBlockBuilderStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the app block builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
