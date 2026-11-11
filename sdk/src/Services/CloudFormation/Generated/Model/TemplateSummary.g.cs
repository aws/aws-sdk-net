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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the generated template was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property GeneratedTemplateId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the generated template. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:generatedtemplate/${Id}</c>.
        /// For example, <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:generatedtemplate/<i>2e8465c1-9a80-43ea-a3a3-4f2d692fe6dc</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GeneratedTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedTemplateId property is set.
        /// </summary>
        internal bool IsSetGeneratedTemplateId() => this.GeneratedTemplateId != null;

        /// <summary>
        /// Gets and sets the property GeneratedTemplateName. 
        /// <para>
        /// The name of the generated template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GeneratedTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedTemplateName property is set.
        /// </summary>
        internal bool IsSetGeneratedTemplateName() => this.GeneratedTemplateName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the generated template was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfResources. 
        /// <para>
        /// The number of resources in the generated template. This is a total of resources in
        /// pending, in-progress, completed, and failed states.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NumberOfResources { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfResources property is set.
        /// </summary>
        internal bool IsSetNumberOfResources() => this.NumberOfResources.HasValue;

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
        public GeneratedTemplateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current template generation status. This will provide more details
        /// if a failure happened.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
