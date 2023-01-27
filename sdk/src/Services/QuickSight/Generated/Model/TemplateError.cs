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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// List of errors that occurred when the template version creation failed.
    /// </summary>
    public partial class TemplateError
    {
        private string _message;
        private TemplateErrorType _type;
        private List<Entity> _violatedEntities = new List<Entity>();

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Description of the error type.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of error.
        /// </para>
        /// </summary>
        public TemplateErrorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ViolatedEntities. 
        /// <para>
        /// An error path that shows which entities caused the template error.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Entity> ViolatedEntities
        {
            get { return this._violatedEntities; }
            set { this._violatedEntities = value; }
        }

        // Check to see if ViolatedEntities property is set
        internal bool IsSetViolatedEntities()
        {
            return this._violatedEntities != null && this._violatedEntities.Count > 0; 
        }

    }
}