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
    /// A batch update data table value success result.
    /// </summary>
    public partial class BatchUpdateDataTableValueSuccessResult
    {
        private string _attributeName;
        private DataTableLockVersion _lockVersion;
        private List<PrimaryValue> _primaryValues = AWSConfigs.InitializeCollections ? new List<PrimaryValue>() : null;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The result's attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The result's lock version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataTableLockVersion LockVersion
        {
            get { return this._lockVersion; }
            set { this._lockVersion = value; }
        }

        // Check to see if LockVersion property is set
        internal bool IsSetLockVersion()
        {
            return this._lockVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The result's primary values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PrimaryValue> PrimaryValues
        {
            get { return this._primaryValues; }
            set { this._primaryValues = value; }
        }

        // Check to see if PrimaryValues property is set
        internal bool IsSetPrimaryValues()
        {
            return this._primaryValues != null && (this._primaryValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}