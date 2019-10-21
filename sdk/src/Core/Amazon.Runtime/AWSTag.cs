/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the ""License"").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the ""license"" file accompanying this file. This file is distributed
 * on an ""AS IS"" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime
{
    /// <summary>
    /// A key-value pair that identifies or specifies metadata about a resource.
    /// </summary>
    public abstract class AWSTag : IEquatable<AWSTag>
    {

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the tag.
        /// </para>
        /// </summary>
        public abstract string Key { get; set; }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the tag.
        /// </para>
        /// </summary>
        public abstract string Value { get; set; }


        /// <summary>
        /// Checks if this object is equal to another.
        /// </summary>
        /// <param name="obj">object to compare to</param>
        /// <returns>True if obj is a Tag and its Key and Value properties match this one.</returns>
        public override bool Equals(object obj)
        {
            return obj is AWSTag t && 
                    this.Key == t.Key && 
                    this.Value == t.Value;
        }

        /// <summary>
        /// Checks if this tag is equal to another.
        /// </summary>
        /// <param name="t">tag to compare to</param>
        /// <returns>True if t is a Tag and its Key and Value properties match this one.</returns>
        public bool Equals(AWSTag t)
        {
            return t != null &&
                    this.Key == t.Key &&
                    this.Value == t.Value;
        }

        /// <summary>
        /// Gets the hash code of this Tag.
        /// </summary>
        /// <returns>A hash code based on the Key and Value properties of this Tag.</returns>
        public override int GetHashCode()
        {
            return new { Key, Value }.GetHashCode();
        }

        /// <summary>
        /// Overrides the equality operator.  Two tags are equal if their Key and Value properties match.
        /// </summary>
        /// <param name="a">Tag to the left of the operator</param>
        /// <param name="b">Tag to the right of the operator</param>
        /// <returns>True if a and b are equal, otherwise false.</returns>
        public static bool operator == (AWSTag a, AWSTag b) 
        {
            if (a == null)
            {
                return b == null;
            }

            return a.Equals(b);
        }

        /// <summary>
        /// Overrides the inequality operator.  Two tags are not equal if either of their Key or Value properties do not match.
        /// </summary>
        /// <param name="a">Tag to the left of the operator</param>
        /// <param name="b">Tag to the right of the operator</param>
        /// <returns>True if a and b are not equal, otherwise false.</returns>
        public static bool operator != (AWSTag a, AWSTag b) 
        {
            if (a == null) 
            {
                return b != null;
            }

            return !a.Equals(b);
        }
    }
}