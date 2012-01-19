/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// <para>AttributeValue can be <c>String</c> ,
    /// <c>Number</c> ,
    /// <c>StringSet</c> ,
    /// <c>NumberSet</c> .</para>
    /// </summary>
    public class AttributeValue  
    {
        
        private string s;
        private string n;
        private List<string> sS = new List<string>();
        private List<string> nS = new List<string>();

        /// <summary>
        /// Strings are Unicode with UTF-8 binary encoding. The maximum size is limited by the size of the primary key (1024 bytes as a range part of a
        /// key or 2048 bytes as a single part hash key) or the item size (64k).
        ///  
        /// </summary>
        public string S
        {
            get { return this.s; }
            set { this.s = value; }
        }

        /// <summary>
        /// Sets the S property
        /// </summary>
        /// <param name="s">The value to set for the S property </param>
        /// <returns>this instance</returns>
        public AttributeValue WithS(string s)
        {
            this.s = s;
            return this;
        }
            

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this.s != null;       
        }

        /// <summary>
        /// Numbers are positive or negative exact-value decimals and integers. A number can have up to 38 digits precision and can be between 10^-128
        /// to 10^+126.
        ///  
        /// </summary>
        public string N
        {
            get { return this.n; }
            set { this.n = value; }
        }

        /// <summary>
        /// Sets the N property
        /// </summary>
        /// <param name="n">The value to set for the N property </param>
        /// <returns>this instance</returns>
        public AttributeValue WithN(string n)
        {
            this.n = n;
            return this;
        }
            

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this.n != null;       
        }

        /// <summary>
        /// A set of strings.
        ///  
        /// </summary>
        public List<string> SS
        {
            get { return this.sS; }
            set { this.sS = value; }
        }
        /// <summary>
        /// Adds elements to the SS collection
        /// </summary>
        /// <param name="sS">The values to add to the SS collection </param>
        /// <returns>this instance</returns>
        public AttributeValue WithSS(params string[] sS)
        {
            foreach (string element in sS)
            {
                this.sS.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SS collection
        /// </summary>
        /// <param name="sS">The values to add to the SS collection </param>
        /// <returns>this instance</returns>
        public AttributeValue WithSS(IEnumerable<string> sS)
        {
            foreach (string element in sS)
            {
                this.sS.Add(element);
            }

            return this;
        }

        // Check to see if SS property is set
        internal bool IsSetSS()
        {
            return this.sS.Count > 0;       
        }

        /// <summary>
        /// A set of numbers.
        ///  
        /// </summary>
        public List<string> NS
        {
            get { return this.nS; }
            set { this.nS = value; }
        }
        /// <summary>
        /// Adds elements to the NS collection
        /// </summary>
        /// <param name="nS">The values to add to the NS collection </param>
        /// <returns>this instance</returns>
        public AttributeValue WithNS(params string[] nS)
        {
            foreach (string element in nS)
            {
                this.nS.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the NS collection
        /// </summary>
        /// <param name="nS">The values to add to the NS collection </param>
        /// <returns>this instance</returns>
        public AttributeValue WithNS(IEnumerable<string> nS)
        {
            foreach (string element in nS)
            {
                this.nS.Add(element);
            }

            return this;
        }

        // Check to see if NS property is set
        internal bool IsSetNS()
        {
            return this.nS.Count > 0;       
        }
    }
}
