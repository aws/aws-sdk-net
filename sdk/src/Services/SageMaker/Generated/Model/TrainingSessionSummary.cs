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
    /// Contains summary information about a training session.
    /// </summary>
    public partial class TrainingSessionSummary
    {
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private string _trainingSessionArn;
        private TrainingSessionStatus _trainingSessionStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the training session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the training session was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string TrainingSessionArn
        {
            get { return this._trainingSessionArn; }
            set { this._trainingSessionArn = value; }
        }

        // Check to see if TrainingSessionArn property is set
        internal bool IsSetTrainingSessionArn()
        {
            return this._trainingSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionStatus. 
        /// <para>
        /// The current status of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingSessionStatus TrainingSessionStatus
        {
            get { return this._trainingSessionStatus; }
            set { this._trainingSessionStatus = value; }
        }

        // Check to see if TrainingSessionStatus property is set
        internal bool IsSetTrainingSessionStatus()
        {
            return this._trainingSessionStatus != null;
        }

    }
}