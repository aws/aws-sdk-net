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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the StartTrainedModelExportJob operation.
    /// Provides the information necessary to start a trained model export job.
    /// </summary>
    public partial class StartTrainedModelExportJobRequest : AmazonCleanRoomsMLRequest
    {
        private string _description;
        private string _membershipIdentifier;
        private string _name;
        private TrainedModelExportOutputConfiguration _outputConfiguration;
        private string _trainedModelArn;
        private string _trainedModelVersionIdentifier;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model export job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that is receiving the exported trained model artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The output configuration information for the trained model export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainedModelExportOutputConfiguration OutputConfiguration
        {
            get { return this._outputConfiguration; }
            set { this._outputConfiguration = value; }
        }

        // Check to see if OutputConfiguration property is set
        internal bool IsSetOutputConfiguration()
        {
            return this._outputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model that you want to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelVersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model to export. This specifies which version
        /// of the trained model should be exported to the specified destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TrainedModelVersionIdentifier
        {
            get { return this._trainedModelVersionIdentifier; }
            set { this._trainedModelVersionIdentifier = value; }
        }

        // Check to see if TrainedModelVersionIdentifier property is set
        internal bool IsSetTrainedModelVersionIdentifier()
        {
            return this._trainedModelVersionIdentifier != null;
        }

    }
}