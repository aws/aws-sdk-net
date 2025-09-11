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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private List<DataSourceParameters> _alternateDataSourceParameters = AWSConfigs.InitializeCollections ? new List<DataSourceParameters>() : null;
        private string _arn;
        private DateTime? _createdTime;
        private string _dataSourceId;
        private DataSourceParameters _dataSourceParameters;
        private DataSourceErrorInfo _errorInfo;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _secretArn;
        private SslProperties _sslProperties;
        private ResourceStatus _status;
        private DataSourceType _type;
        private VpcConnectionProperties _vpcConnectionProperties;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<DataSourceParameters> AlternateDataSourceParameters
        {
            get { return this._alternateDataSourceParameters; }
            set { this._alternateDataSourceParameters = value; }
        }

        // Check to see if AlternateDataSourceParameters property is set
        internal bool IsSetAlternateDataSourceParameters()
        {
            return this._alternateDataSourceParameters != null && (this._alternateDataSourceParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this data source was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source. This ID is unique per Amazon Web Services Region for each
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceParameters. 
        /// <para>
        /// The parameters that Amazon QuickSight uses to connect to your underlying source. This
        /// is a variant type structure. For this structure to be valid, only one of the attributes
        /// can be non-null.
        /// </para>
        /// </summary>
        public DataSourceParameters DataSourceParameters
        {
            get { return this._dataSourceParameters; }
            set { this._dataSourceParameters = value; }
        }

        // Check to see if DataSourceParameters property is set
        internal bool IsSetDataSourceParameters()
        {
            return this._dataSourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information from the last update or the creation of the data source.
        /// </para>
        /// </summary>
        public DataSourceErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that this data source was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret associated with the data source in Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslProperties. 
        /// <para>
        /// Secure Socket Layer (SSL) properties that apply when QuickSight connects to your underlying
        /// source.
        /// </para>
        /// </summary>
        public SslProperties SslProperties
        {
            get { return this._sslProperties; }
            set { this._sslProperties = value; }
        }

        // Check to see if SslProperties property is set
        internal bool IsSetSslProperties()
        {
            return this._sslProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. This type indicates which database engine the data source
        /// connects to.
        /// </para>
        /// </summary>
        public DataSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// The VPC connection information. You need to use this parameter only when you want
        /// QuickSight to use a VPC connection when connecting to your underlying source.
        /// </para>
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties
        {
            get { return this._vpcConnectionProperties; }
            set { this._vpcConnectionProperties = value; }
        }

        // Check to see if VpcConnectionProperties property is set
        internal bool IsSetVpcConnectionProperties()
        {
            return this._vpcConnectionProperties != null;
        }

    }
}