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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the UpdateMlflowApp operation.
    /// Updates an MLflow App.
    /// </summary>
    public partial class UpdateMlflowAppRequest : AmazonSageMakerRequest
    {
        private AccountDefaultStatus _accountDefaultStatus;
        private string _arn;
        private string _artifactStoreUri;
        private List<string> _defaultDomainIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ModelRegistrationMode _modelRegistrationMode;
        private string _name;
        private string _weeklyMaintenanceWindowStart;

        /// <summary>
        /// Gets and sets the property AccountDefaultStatus. 
        /// <para>
        /// Indicates whether this this MLflow App is the default for the account.
        /// </para>
        /// </summary>
        public AccountDefaultStatus AccountDefaultStatus
        {
            get { return this._accountDefaultStatus; }
            set { this._accountDefaultStatus = value; }
        }

        // Check to see if AccountDefaultStatus property is set
        internal bool IsSetAccountDefaultStatus()
        {
            return this._accountDefaultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the MLflow App to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ArtifactStoreUri. 
        /// <para>
        /// The new S3 URI for the general purpose bucket to use as the artifact store for the
        /// MLflow App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ArtifactStoreUri
        {
            get { return this._artifactStoreUri; }
            set { this._artifactStoreUri = value; }
        }

        // Check to see if ArtifactStoreUri property is set
        internal bool IsSetArtifactStoreUri()
        {
            return this._artifactStoreUri != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultDomainIdList. 
        /// <para>
        /// List of SageMaker Domain IDs for which this MLflow App is the default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DefaultDomainIdList
        {
            get { return this._defaultDomainIdList; }
            set { this._defaultDomainIdList = value; }
        }

        // Check to see if DefaultDomainIdList property is set
        internal bool IsSetDefaultDomainIdList()
        {
            return this._defaultDomainIdList != null && (this._defaultDomainIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelRegistrationMode. 
        /// <para>
        /// Whether to enable or disable automatic registration of new MLflow models to the SageMaker
        /// Model Registry. To enable automatic model registration, set this value to <c>AutoModelRegistrationEnabled</c>.
        /// To disable automatic model registration, set this value to <c>AutoModelRegistrationDisabled</c>.
        /// If not specified, <c>AutomaticModelRegistration</c> defaults to <c>AutoModelRegistrationEnabled</c>
        /// 
        /// </para>
        /// </summary>
        public ModelRegistrationMode ModelRegistrationMode
        {
            get { return this._modelRegistrationMode; }
            set { this._modelRegistrationMode = value; }
        }

        // Check to see if ModelRegistrationMode property is set
        internal bool IsSetModelRegistrationMode()
        {
            return this._modelRegistrationMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the MLflow App to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property WeeklyMaintenanceWindowStart. 
        /// <para>
        /// The new weekly maintenance window start day and time to update. The maintenance window
        /// day and time should be in Coordinated Universal Time (UTC) 24-hour standard time.
        /// For example: TUE:03:30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
        public string WeeklyMaintenanceWindowStart
        {
            get { return this._weeklyMaintenanceWindowStart; }
            set { this._weeklyMaintenanceWindowStart = value; }
        }

        // Check to see if WeeklyMaintenanceWindowStart property is set
        internal bool IsSetWeeklyMaintenanceWindowStart()
        {
            return this._weeklyMaintenanceWindowStart != null;
        }

    }
}