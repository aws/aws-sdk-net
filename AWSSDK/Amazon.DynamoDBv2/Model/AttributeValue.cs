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

        /// <summary>
        /// Sets the S property
        /// </summary>
        /// <param name="s">The value to set for the S property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Represents a Number data type
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Represents a Binary data type
        ///  
        /// </summary>
        public MemoryStream B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        /// <summary>
        /// Sets the B property
        /// </summary>
        /// <param name="b">The value to set for the B property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttributeValue WithB(MemoryStream b)
        {
            this.b = b;
            return this;
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
        /// <summary>
        /// Adds elements to the SS collection
        /// </summary>
        /// <param name="sS">The values to add to the SS collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Represents a Number set data type
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// Represents a Binary set data type
        ///  
        /// </summary>
        public List<MemoryStream> BS
        {
            get { return this.bS; }
            set { this.bS = value; }
        }
        /// <summary>
        /// Adds elements to the BS collection
        /// </summary>
        /// <param name="bS">The values to add to the BS collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttributeValue WithBS(params MemoryStream[] bS)
        {
            foreach (MemoryStream element in bS)
            {
                this.bS.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the BS collection
        /// </summary>
        /// <param name="bS">The values to add to the BS collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AttributeValue WithBS(IEnumerable<MemoryStream> bS)
        {
            foreach (MemoryStream element in bS)
            {
                this.bS.Add(element);
            }

            return this;
        }

        // Check to see if BS property is set
        internal bool IsSetBS()
        {
            return this.bS.Count > 0;
        }
    }
}
