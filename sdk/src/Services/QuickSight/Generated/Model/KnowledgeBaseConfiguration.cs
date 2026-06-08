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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration settings for a knowledge base.
    /// </summary>
    public partial class KnowledgeBaseConfiguration
    {
        private bool? _eventEnabled;
        private KbTemplateConfiguration _templateConfiguration;

        /// <summary>
        /// Gets and sets the property EventEnabled. 
        /// <para>
        /// Indicates whether event notifications are enabled for the knowledge base.
        /// </para>
        /// </summary>
        public bool? EventEnabled
        {
            get { return this._eventEnabled; }
            set { this._eventEnabled = value; }
        }

        // Check to see if EventEnabled property is set
        internal bool IsSetEventEnabled()
        {
            return this._eventEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// The template configuration for the knowledge base.
        /// </para>
        /// </summary>
        public KbTemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

    }
}