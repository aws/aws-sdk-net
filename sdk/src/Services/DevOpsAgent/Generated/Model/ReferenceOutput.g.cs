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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Reference information linking a task to external systems - for output without validation
    /// </summary>
    public partial class ReferenceOutput
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// Association identifier of the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The unique identifier in the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;

        /// <summary>
        /// Gets and sets the property ReferenceUrl. 
        /// <para>
        /// URL to access the reference in the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceUrl property is set.
        /// </summary>
        internal bool IsSetReferenceUrl() => this.ReferenceUrl != null;

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// The name of the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string System { get; set; }

        /// <summary>
        /// Checks to see if the System property is set.
        /// </summary>
        internal bool IsSetSystem() => this.System != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Optional title for the reference
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
