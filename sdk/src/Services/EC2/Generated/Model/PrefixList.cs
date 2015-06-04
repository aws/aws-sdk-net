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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes prefixes for AWS services.
    /// </summary>
    public partial class PrefixList
    {
        private List<string> _cidrs = new List<string>();
        private string _prefixListId;
        private string _prefixListName;

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The IP address range of the AWS service.
        /// </para>
        /// </summary>
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && this._cidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix. 
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListName. 
        /// <para>
        /// The name of the prefix.
        /// </para>
        /// </summary>
        public string PrefixListName
        {
            get { return this._prefixListName; }
            set { this._prefixListName = value; }
        }

        // Check to see if PrefixListName property is set
        internal bool IsSetPrefixListName()
        {
            return this._prefixListName != null;
        }

    }
}