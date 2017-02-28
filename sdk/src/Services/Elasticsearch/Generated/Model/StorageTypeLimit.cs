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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Limits that are applicable for given storage type.
    /// </summary>
    public partial class StorageTypeLimit
    {
        private string _limitName;
        private List<string> _limitValues = new List<string>();

        /// <summary>
        /// Gets and sets the property LimitName. 
        /// <para>
        ///  Name of storage limits that are applicable for given storage type. If <code> <a>StorageType</a>
        /// </code> is ebs, following storage options are applicable <ol> <li>MinimumVolumeSize</li>
        /// Minimum amount of volume size that is applicable for given storage type.It can be
        /// empty if it is not applicable. <li>MaximumVolumeSize</li> Maximum amount of volume
        /// size that is applicable for given storage type.It can be empty if it is not applicable.
        /// <li>MaximumIops</li> Maximum amount of Iops that is applicable for given storage type.It
        /// can be empty if it is not applicable. <li>MinimumIops</li> Minimum amount of Iops
        /// that is applicable for given storage type.It can be empty if it is not applicable.
        /// </ol> 
        /// </para>
        /// </summary>
        public string LimitName
        {
            get { return this._limitName; }
            set { this._limitName = value; }
        }

        // Check to see if LimitName property is set
        internal bool IsSetLimitName()
        {
            return this._limitName != null;
        }

        /// <summary>
        /// Gets and sets the property LimitValues. 
        /// <para>
        ///  Values for the <code> <a>StorageTypeLimit$LimitName</a> </code> . 
        /// </para>
        /// </summary>
        public List<string> LimitValues
        {
            get { return this._limitValues; }
            set { this._limitValues = value; }
        }

        // Check to see if LimitValues property is set
        internal bool IsSetLimitValues()
        {
            return this._limitValues != null && this._limitValues.Count > 0; 
        }

    }
}