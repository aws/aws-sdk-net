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
    /// A structure describing the current state of the model in its life cycle.
    /// </summary>
    public partial class ModelLifeCycle
    {
        private string _stage;
        private string _stageDescription;
        private string _stageStatus;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  The current stage in the model life cycle. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property StageDescription. 
        /// <para>
        ///  Describes the stage related details. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StageDescription
        {
            get { return this._stageDescription; }
            set { this._stageDescription = value; }
        }

        // Check to see if StageDescription property is set
        internal bool IsSetStageDescription()
        {
            return this._stageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StageStatus. 
        /// <para>
        ///  The current status of a stage in model life cycle. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string StageStatus
        {
            get { return this._stageStatus; }
            set { this._stageStatus = value; }
        }

        // Check to see if StageStatus property is set
        internal bool IsSetStageStatus()
        {
            return this._stageStatus != null;
        }

    }
}