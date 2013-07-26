/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Item
    {
        
        private string name;
        private string alternateNameEncoding;
        private List<Attribute> attributes = new List<Attribute>();

        /// <summary>
        /// The name of the item.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string AlternateNameEncoding
        {
            get { return this.alternateNameEncoding; }
            set { this.alternateNameEncoding = value; }
        }

        // Check to see if AlternateNameEncoding property is set
        internal bool IsSetAlternateNameEncoding()
        {
            return this.alternateNameEncoding != null;
        }

        /// <summary>
        /// A list of attributes.
        ///  
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes.Count > 0;
        }
    }
}
