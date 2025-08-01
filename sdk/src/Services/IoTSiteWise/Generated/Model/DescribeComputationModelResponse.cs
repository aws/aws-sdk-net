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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeComputationModel operation.
    /// </summary>
    public partial class DescribeComputationModelResponse : AmazonWebServiceResponse
    {
        private List<ActionDefinition> _actionDefinitions = AWSConfigs.InitializeCollections ? new List<ActionDefinition>() : null;
        private string _computationModelArn;
        private ComputationModelConfiguration _computationModelConfiguration;
        private DateTime? _computationModelCreationDate;
        private Dictionary<string, ComputationModelDataBindingValue> _computationModelDataBinding = AWSConfigs.InitializeCollections ? new Dictionary<string, ComputationModelDataBindingValue>() : null;
        private string _computationModelDescription;
        private string _computationModelId;
        private DateTime? _computationModelLastUpdateDate;
        private string _computationModelName;
        private ComputationModelStatus _computationModelStatus;
        private string _computationModelVersion;

        /// <summary>
        /// Gets and sets the property ActionDefinitions. 
        /// <para>
        /// The available actions for this computation model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ActionDefinition> ActionDefinitions
        {
            get { return this._actionDefinitions; }
            set { this._actionDefinitions = value; }
        }

        // Check to see if ActionDefinitions property is set
        internal bool IsSetActionDefinitions()
        {
            return this._actionDefinitions != null && (this._actionDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputationModelArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the computation model, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:computation-model/${ComputationModelId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ComputationModelArn
        {
            get { return this._computationModelArn; }
            set { this._computationModelArn = value; }
        }

        // Check to see if ComputationModelArn property is set
        internal bool IsSetComputationModelArn()
        {
            return this._computationModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelConfiguration. 
        /// <para>
        /// The configuration for the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputationModelConfiguration ComputationModelConfiguration
        {
            get { return this._computationModelConfiguration; }
            set { this._computationModelConfiguration = value; }
        }

        // Check to see if ComputationModelConfiguration property is set
        internal bool IsSetComputationModelConfiguration()
        {
            return this._computationModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelCreationDate. 
        /// <para>
        /// The model creation date, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ComputationModelCreationDate
        {
            get { return this._computationModelCreationDate; }
            set { this._computationModelCreationDate = value; }
        }

        // Check to see if ComputationModelCreationDate property is set
        internal bool IsSetComputationModelCreationDate()
        {
            return this._computationModelCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputationModelDataBinding. 
        /// <para>
        /// The data binding for the computation model. Key is a variable name defined in configuration.
        /// Value is a <c>ComputationModelDataBindingValue</c> referenced by the variable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, ComputationModelDataBindingValue> ComputationModelDataBinding
        {
            get { return this._computationModelDataBinding; }
            set { this._computationModelDataBinding = value; }
        }

        // Check to see if ComputationModelDataBinding property is set
        internal bool IsSetComputationModelDataBinding()
        {
            return this._computationModelDataBinding != null && (this._computationModelDataBinding.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputationModelDescription. 
        /// <para>
        /// The description of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ComputationModelDescription
        {
            get { return this._computationModelDescription; }
            set { this._computationModelDescription = value; }
        }

        // Check to see if ComputationModelDescription property is set
        internal bool IsSetComputationModelDescription()
        {
            return this._computationModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelId. 
        /// <para>
        /// The ID of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ComputationModelId
        {
            get { return this._computationModelId; }
            set { this._computationModelId = value; }
        }

        // Check to see if ComputationModelId property is set
        internal bool IsSetComputationModelId()
        {
            return this._computationModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelLastUpdateDate. 
        /// <para>
        /// The date the model was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ComputationModelLastUpdateDate
        {
            get { return this._computationModelLastUpdateDate; }
            set { this._computationModelLastUpdateDate = value; }
        }

        // Check to see if ComputationModelLastUpdateDate property is set
        internal bool IsSetComputationModelLastUpdateDate()
        {
            return this._computationModelLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputationModelName. 
        /// <para>
        /// The name of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ComputationModelName
        {
            get { return this._computationModelName; }
            set { this._computationModelName = value; }
        }

        // Check to see if ComputationModelName property is set
        internal bool IsSetComputationModelName()
        {
            return this._computationModelName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelStatus. 
        /// <para>
        /// The current status of the asset model, which contains a state and an error message
        /// if any.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputationModelStatus ComputationModelStatus
        {
            get { return this._computationModelStatus; }
            set { this._computationModelStatus = value; }
        }

        // Check to see if ComputationModelStatus property is set
        internal bool IsSetComputationModelStatus()
        {
            return this._computationModelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationModelVersion. 
        /// <para>
        /// The version of the computation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string ComputationModelVersion
        {
            get { return this._computationModelVersion; }
            set { this._computationModelVersion = value; }
        }

        // Check to see if ComputationModelVersion property is set
        internal bool IsSetComputationModelVersion()
        {
            return this._computationModelVersion != null;
        }

    }
}