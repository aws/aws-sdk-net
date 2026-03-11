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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that describes a control's relationship status with other controls.
    /// </summary>
    public partial class RelatedControlMappingDetails
    {
        private string _controlArn;
        private ControlRelationType _relationType;

        /// <summary>
        /// Gets and sets the property ControlArn. 
        /// <para>
        /// The unique identifier of a control.
        /// </para>
        /// </summary>
        [AWSProperty(Min=34, Max=2048)]
        public string ControlArn
        {
            get { return this._controlArn; }
            set { this._controlArn = value; }
        }

        // Check to see if ControlArn property is set
        internal bool IsSetControlArn()
        {
            return this._controlArn != null;
        }

        /// <summary>
        /// Gets and sets the property RelationType. 
        /// <para>
        /// Returns an enumerated value that represents the relationship between two or more controls.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlRelationType RelationType
        {
            get { return this._relationType; }
            set { this._relationType = value; }
        }

        // Check to see if RelationType property is set
        internal bool IsSetRelationType()
        {
            return this._relationType != null;
        }

    }
}