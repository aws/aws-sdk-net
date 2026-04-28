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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private string _associationId;
        private string _referenceId;
        private string _referenceUrl;
        private string _system;
        private string _title;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// Association identifier of the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The unique identifier in the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceUrl. 
        /// <para>
        /// URL to access the reference in the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReferenceUrl
        {
            get { return this._referenceUrl; }
            set { this._referenceUrl = value; }
        }

        // Check to see if ReferenceUrl property is set
        internal bool IsSetReferenceUrl()
        {
            return this._referenceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// The name of the external system
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string System
        {
            get { return this._system; }
            set { this._system = value; }
        }

        // Check to see if System property is set
        internal bool IsSetSystem()
        {
            return this._system != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Optional title for the reference
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}