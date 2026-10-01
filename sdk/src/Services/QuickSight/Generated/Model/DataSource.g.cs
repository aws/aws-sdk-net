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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The structure of a data source.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Gets and sets the property AlternateDataSourceParameters. 
        /// <para>
        /// A set of alternate data source parameters that you want to share for the credentials
        /// stored with this data source. The credentials are applied in tandem with the data
        /// source parameters when you copy a data source by using a create or update request.
        /// The API operation compares the <c>DataSourceParameters</c> structure that's in the
        /// request with the structures in the <c>AlternateDataSourceParameters</c> allow list.
        /// If the structures are an exact match, the request is allowed to use the credentials
        /// from this existing data source. If the <c>AlternateDataSourceParameters</c> list is
        /// null, the <c>Credentials</c> originally used with this <c>DataSourceParameters</c>
        /// are automatically allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<DataSourceParameters> AlternateDataSourceParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceParameters>() : null;

        /// <summary>
        /// Checks to see if the AlternateDataSourceParameters property is set.
        /// </summary>
        internal bool IsSetAlternateDataSourceParameters() => this.AlternateDataSourceParameters != null && (this.AlternateDataSourceParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this data source was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialStatus. 
        /// <para>
        /// The credential verification status of the data source. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONNECTED</c> – Credential validation succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTH_FAILED</c> – Credential validation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_VERIFIED</c> – Credential validation has not been performed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CredentialStatus CredentialStatus { get; set; }

        /// <summary>
        /// Checks to see if the CredentialStatus property is set.
        /// </summary>
        internal bool IsSetCredentialStatus() => this.CredentialStatus != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source. This ID is unique per Amazon Web Services Region for each
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property DataSourceParameters. 
        /// <para>
        /// The parameters that Quick Sight uses to connect to your underlying source. This is
        /// a variant type structure. For this structure to be valid, only one of the attributes
        /// can be non-null.
        /// </para>
        /// </summary>
        public DataSourceParameters DataSourceParameters { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceParameters property is set.
        /// </summary>
        internal bool IsSetDataSourceParameters() => this.DataSourceParameters != null;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information from the last update or the creation of the data source.
        /// </para>
        /// </summary>
        public DataSourceErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property LastCredentialVerifiedAt. 
        /// <para>
        /// The time that the credentials were last verified.
        /// </para>
        /// </summary>
        public DateTime? LastCredentialVerifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastCredentialVerifiedAt property is set.
        /// </summary>
        internal bool IsSetLastCredentialVerifiedAt() => this.LastCredentialVerifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this data source was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret associated with the data source in Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SslProperties. 
        /// <para>
        /// Secure Socket Layer (SSL) properties that apply when Quick Sight connects to your
        /// underlying source.
        /// </para>
        /// </summary>
        public SslProperties SslProperties { get; set; }

        /// <summary>
        /// Checks to see if the SslProperties property is set.
        /// </summary>
        internal bool IsSetSslProperties() => this.SslProperties != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. This type indicates which database engine the data source
        /// connects to.
        /// </para>
        /// </summary>
        public DataSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// The VPC connection information. You need to use this parameter only when you want
        /// Quick Sight to use a VPC connection when connecting to your underlying source.
        /// </para>
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetVpcConnectionProperties() => this.VpcConnectionProperties != null;
    }
}
