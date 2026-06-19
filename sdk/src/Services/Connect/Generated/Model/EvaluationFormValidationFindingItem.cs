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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about an evaluation form item affected by a validation finding.
    /// </summary>
    public partial class EvaluationFormValidationFindingItem
    {
        private string _property;
        private string _refId;

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The specific property of the evaluation form item that the finding relates to.
        /// </para>
        /// </summary>
        public string Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the evaluation form item (question or section) affected by the finding.
        /// </para>
        /// </summary>
        public string RefId
        {
            get { return this._refId; }
            set { this._refId = value; }
        }

        // Check to see if RefId property is set
        internal bool IsSetRefId()
        {
            return this._refId != null;
        }

    }
}