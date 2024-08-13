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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The summary of a generated template.
    /// </summary>
    public partial class TemplateSummary
    {
        private DateTime? _creationTime;
        private string _generatedTemplateId;
        private string _generatedTemplateName;
        private DateTime? _lastUpdatedTime;
        private int? _numberOfResources;
        private GeneratedTemplateStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the generated template was created.
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
        /// Gets and sets the property GeneratedTemplateId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the generated template. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:generatedtemplate/${Id}</c>.
        /// For example, <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:generatedtemplate/<i>2e8465c1-9a80-43ea-a3a3-4f2d692fe6dc</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GeneratedTemplateId
        {
            get { return this._generatedTemplateId; }
            set { this._generatedTemplateId = value; }
        }

        // Check to see if GeneratedTemplateId property is set
        internal bool IsSetGeneratedTemplateId()
        {
            return this._generatedTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name of the generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string GeneratedTemplateName
        {
            get { return this._generatedTemplateName; }
            set { this._generatedTemplateName = value; }
        }

        // Check to see if GeneratedTemplateName property is set
        internal bool IsSetGeneratedTemplateName()
        {
            return this._generatedTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the generated template was last updated.
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
        /// Gets and sets the property NumberOfResources. 
        /// <para>
        /// The number of resources in the generated template. This is a total of resources in
        /// pending, in-progress, completed, and failed states.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumberOfResources
        {
            get { return this._numberOfResources; }
            set { this._numberOfResources = value; }
        }

        // Check to see if NumberOfResources property is set
        internal bool IsSetNumberOfResources()
        {
            return this._numberOfResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the template generation. Supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreatePending</c> - the creation of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreateInProgress</c> - the creation of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeletePending</c> - the deletion of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteInProgress</c> - the deletion of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdatePending</c> - the update of the template is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UpdateInProgress</c> - the update of the template is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - the template operation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Complete</c> - the template operation is complete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GeneratedTemplateStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current template generation status. This will provide more details
        /// if a failure happened.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}