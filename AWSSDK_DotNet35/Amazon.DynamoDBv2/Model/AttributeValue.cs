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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the data for an attribute. You can set one, and only one, of the elements.</para>
    /// </summary>
    public class AttributeValue
    {
        
        private string s;
        private string n;
        private MemoryStream b;
        private List<string> sS = new List<string>();
        private List<string> nS = new List<string>();
        private List<MemoryStream> bS = new List<MemoryStream>();


        /// <summary>
        /// Represents a String data type
        ///  
        /// </summary>
        public string S
        {
            get { return this.s; }
            set { this.s = value; }
        }

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this.s != null;
        }

        /// <summary>
        /// Represents a Number data type
        ///  
        /// </summary>
        public string N
        {
            get { return this.n; }
            set { this.n = value; }
        }

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this.n != null;
        }

        /// <summary>
        /// Represents a Binary data type
        ///  
        /// </summary>
        public MemoryStream B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        // Check to see if B property is set
        internal bool IsSetB()
        {
            return this.b != null;
        }

        /// <summary>
        /// Represents a String set data type
        ///  
        /// </summary>
        public List<string> SS
        {
            get { return this.sS; }
            set { this.sS = value; }
        }

        // Check to see if SS property is set
        internal bool IsSetSS()
        {
            return this.sS.Count > 0;
        }

        /// <summary>
        /// Represents a Number set data type
        ///  
        /// </summary>
        public List<string> NS
        {
            get { return this.nS; }
            set { this.nS = value; }
        }

        // Check to see if NS property is set
        internal bool IsSetNS()
        {
            return this.nS.Count > 0;
        }

        /// <summary>
        /// Represents a Binary set data type
        ///  
        /// </summary>
        public List<MemoryStream> BS
        {
            get { return this.bS; }
            set { this.bS = value; }
        }

        // Check to see if BS property is set
        internal bool IsSetBS()
        {
            return this.bS.Count > 0;
        }
    }
}
