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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A data structure with information about any primary and secondary clusters associated
    /// with an Aurora global database.
    /// </summary>
    public partial class GlobalClusterMember
    {
        private string _dbClusterArn;
        private bool? _isWriter;
        private List<string> _readers = new List<string>();

        /// <summary>
        /// Gets and sets the property DBClusterArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for each Aurora cluster. 
        /// </para>
        /// </summary>
        public string DBClusterArn
        {
            get { return this._dbClusterArn; }
            set { this._dbClusterArn = value; }
        }

        // Check to see if DBClusterArn property is set
        internal bool IsSetDBClusterArn()
        {
            return this._dbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsWriter. 
        /// <para>
        ///  Specifies whether the Aurora cluster is the primary cluster (that is, has read-write
        /// capability) for the Aurora global database with which it is associated. 
        /// </para>
        /// </summary>
        public bool IsWriter
        {
            get { return this._isWriter.GetValueOrDefault(); }
            set { this._isWriter = value; }
        }

        // Check to see if IsWriter property is set
        internal bool IsSetIsWriter()
        {
            return this._isWriter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Readers. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for each read-only secondary cluster associated with
        /// the Aurora global database. 
        /// </para>
        /// </summary>
        public List<string> Readers
        {
            get { return this._readers; }
            set { this._readers = value; }
        }

        // Check to see if Readers property is set
        internal bool IsSetReaders()
        {
            return this._readers != null && this._readers.Count > 0; 
        }

    }
}