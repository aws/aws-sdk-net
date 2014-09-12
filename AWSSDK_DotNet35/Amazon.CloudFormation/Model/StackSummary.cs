/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The StackSummary Data Type
    /// </summary>
    public partial class StackSummary
    {
        private DateTime? _creationTime;
        private DateTime? _deletionTime;
        private DateTime? _lastUpdatedTime;
        private string _stackId;
        private string _stackName;
        private StackStatus _stackStatus;
        private string _stackStatusReason;
        private string _templateDescription;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the stack was created.
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
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The time the stack was deleted.
        /// </para>
        /// </summary>
        public DateTime DeletionTime
        {
            get { return this._deletionTime.GetValueOrDefault(); }
            set { this._deletionTime = value; }
        }

        // Check to see if DeletionTime property is set
        internal bool IsSetDeletionTime()
        {
            return this._deletionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// Unique stack identifier.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with the stack.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatus. 
        /// <para>
        /// The current status of the stack.
        /// </para>
        /// </summary>
        public StackStatus StackStatus
        {
            get { return this._stackStatus; }
            set { this._stackStatus = value; }
        }

        // Check to see if StackStatus property is set
        internal bool IsSetStackStatus()
        {
            return this._stackStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StackStatusReason. 
        /// <para>
        /// Success/Failure message associated with the stack status.
        /// </para>
        /// </summary>
        public string StackStatusReason
        {
            get { return this._stackStatusReason; }
            set { this._stackStatusReason = value; }
        }

        // Check to see if StackStatusReason property is set
        internal bool IsSetStackStatusReason()
        {
            return this._stackStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// The template description of the template used to create the stack.
        /// </para>
        /// </summary>
        public string TemplateDescription
        {
            get { return this._templateDescription; }
            set { this._templateDescription = value; }
        }

        // Check to see if TemplateDescription property is set
        internal bool IsSetTemplateDescription()
        {
            return this._templateDescription != null;
        }

    }
}