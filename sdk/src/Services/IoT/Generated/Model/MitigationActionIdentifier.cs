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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information that identifies a mitigation action. This information is returned by ListMitigationActions.
    /// </summary>
    public partial class MitigationActionIdentifier
    {
        private string _actionArn;
        private string _actionName;
        private DateTime? _creationDate;

        /// <summary>
        /// Gets and sets the property ActionArn. 
        /// <para>
        /// The IAM role ARN used to apply this mitigation action.
        /// </para>
        /// </summary>
        public string ActionArn
        {
            get { return this._actionArn; }
            set { this._actionArn = value; }
        }

        // Check to see if ActionArn property is set
        internal bool IsSetActionArn()
        {
            return this._actionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The friendly name of the mitigation action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when this mitigation action was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

    }
}