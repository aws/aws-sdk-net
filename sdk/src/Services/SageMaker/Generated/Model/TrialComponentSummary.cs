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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of the properties of a trial component. To get all the properties, call
    /// the <a>DescribeTrialComponent</a> API and provide the <code>TrialComponentName</code>.
    /// </summary>
    public partial class TrialComponentSummary
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _displayName;
        private DateTime? _endTime;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private DateTime? _startTime;
        private TrialComponentStatus _status;
        private string _trialComponentArn;
        private string _trialComponentName;
        private TrialComponentSource _trialComponentSource;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the trial component.
        /// </para>
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the component was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The name of the component as displayed. If <code>DisplayName</code> isn't specified,
        /// <code>TrialComponentName</code> is displayed.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the component ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who last modified the component.
        /// </para>
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the component was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the component started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TrialComponentStatus Status
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
        /// Gets and sets the property TrialComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TrialComponentArn
        {
            get { return this._trialComponentArn; }
            set { this._trialComponentArn = value; }
        }

        // Check to see if TrialComponentArn property is set
        internal bool IsSetTrialComponentArn()
        {
            return this._trialComponentArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string TrialComponentName
        {
            get { return this._trialComponentName; }
            set { this._trialComponentName = value; }
        }

        // Check to see if TrialComponentName property is set
        internal bool IsSetTrialComponentName()
        {
            return this._trialComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property TrialComponentSource.
        /// </summary>
        public TrialComponentSource TrialComponentSource
        {
            get { return this._trialComponentSource; }
            set { this._trialComponentSource = value; }
        }

        // Check to see if TrialComponentSource property is set
        internal bool IsSetTrialComponentSource()
        {
            return this._trialComponentSource != null;
        }

    }
}