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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetTriggers operation.
    /// </summary>
    public partial class BatchGetTriggersResponse : AmazonWebServiceResponse
    {
        private List<Trigger> _triggers = new List<Trigger>();
        private List<string> _triggersNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// A list of trigger definitions.
        /// </para>
        /// </summary>
        public List<Trigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && this._triggers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggersNotFound. 
        /// <para>
        /// A list of names of triggers not found.
        /// </para>
        /// </summary>
        public List<string> TriggersNotFound
        {
            get { return this._triggersNotFound; }
            set { this._triggersNotFound = value; }
        }

        // Check to see if TriggersNotFound property is set
        internal bool IsSetTriggersNotFound()
        {
            return this._triggersNotFound != null && this._triggersNotFound.Count > 0; 
        }

    }
}