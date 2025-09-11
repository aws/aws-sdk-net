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
    /// A structure that contains information about the <c>QDataKey</c>.
    /// </summary>
    public partial class QDataKey
    {
        private string _qDataKeyArn;
        private QDataKeyType _qDataKeyType;

        /// <summary>
        /// Gets and sets the property QDataKeyArn. 
        /// <para>
        /// The ARN of the KMS key that is registered to a QuickSight account for encryption and
        /// decryption use as a <c>QDataKey</c>.
        /// </para>
        /// </summary>
        public string QDataKeyArn
        {
            get { return this._qDataKeyArn; }
            set { this._qDataKeyArn = value; }
        }

        // Check to see if QDataKeyArn property is set
        internal bool IsSetQDataKeyArn()
        {
            return this._qDataKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property QDataKeyType. 
        /// <para>
        /// The type of <c>QDataKey</c>.
        /// </para>
        /// </summary>
        public QDataKeyType QDataKeyType
        {
            get { return this._qDataKeyType; }
            set { this._qDataKeyType = value; }
        }

        // Check to see if QDataKeyType property is set
        internal bool IsSetQDataKeyType()
        {
            return this._qDataKeyType != null;
        }

    }
}