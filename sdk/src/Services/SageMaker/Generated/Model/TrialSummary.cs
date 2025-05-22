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
    /// A summary of the properties of a trial. To get the complete set of properties, call
    /// the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeTrial.html">DescribeTrial</a>
    /// API and provide the <c>TrialName</c>.
    /// </summary>
    public partial class TrialSummary
    {
        private DateTime? _creationTime;
        private string _displayName;
        private DateTime? _lastModifiedTime;
        private string _trialArn;
        private string _trialName;
        private TrialSource _trialSource;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the trial was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the trial as displayed. If <c>DisplayName</c> isn't specified, <c>TrialName</c>
        /// is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the trial was last modified.
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
        /// Gets and sets the property TrialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trial.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string TrialArn
        {
            get { return this._trialArn; }
            set { this._trialArn = value; }
        }

        // Check to see if TrialArn property is set
        internal bool IsSetTrialArn()
        {
            return this._trialArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of the trial.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string TrialName
        {
            get { return this._trialName; }
            set { this._trialName = value; }
        }

        // Check to see if TrialName property is set
        internal bool IsSetTrialName()
        {
            return this._trialName != null;
        }

        /// <summary>
        /// Gets and sets the property TrialSource.
        /// </summary>
        public TrialSource TrialSource
        {
            get { return this._trialSource; }
            set { this._trialSource = value; }
        }

        // Check to see if TrialSource property is set
        internal bool IsSetTrialSource()
        {
            return this._trialSource != null;
        }

    }
}