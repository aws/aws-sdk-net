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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListObjects response and response metadata.
    /// </summary>
    public class ListObjectsResponse : AmazonWebServiceResponse
    {
        private bool? isTruncated;
        private string nextMarker;
        private List<S3Object> contents = new List<S3Object>();
        private string name;
        private string prefix;
        private int? maxKeys;
        private List<string> commonPrefixes = new List<string>();
        private string delimiter;

        /// <summary>
        /// A flag that indicates whether or not Amazon S3 returned all of the results that satisfied 
        /// the search criteria.
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// Gets and sets the NextMarker property.
        /// NextMarker is set by S3 only if a Delimiter was specified
        /// in the original ListObjects request. If a delimiter was
        /// not specified, the AWS SDK for .NET returns the last Key
        /// of the List of Objects retrieved from S3 as the NextMarker.
        /// </summary>
        public string NextMarker
        {
            get 
            {
                // If the list is truncated and there is at least
                // one object in the list returned and nextMarker
                // has not been populated with a value, use the
                // last returned Key as the default value.
                if (System.String.IsNullOrEmpty(nextMarker) &&
                    isTruncated.GetValueOrDefault() &&
                    (this.S3Objects.Count > 0))
                {
                    int lastObjIdx = this.S3Objects.Count - 1;
                    nextMarker = this.S3Objects[lastObjIdx].Key;
                }

                return this.nextMarker; 
            }
            set { this.nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this.nextMarker != null;
        }

        /// <summary>
        /// Gets the S3Objects property. This is a list of 
        /// objects in the bucket that match your search criteria.
        /// </summary>
        public List<S3Object> S3Objects
        {
            get { return this.contents; }
            set { this.contents = value; }
        }

        // Check to see if Contents property is set
        internal bool IsSetContents()
        {
            return this.contents.Count > 0;
        }

        /// <summary>
        /// Gets and sets the Name property which is the name of the bucket.
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
        /// Gets and sets the Prefix property.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// Gets and sets the MaxKeys property. This is max number of object keys returned by the list operation.
        /// </summary>
        public int MaxKeys
        {
            get { return this.maxKeys ?? default(int); }
            set { this.maxKeys = value; }
        }

        // Check to see if MaxKeys property is set
        internal bool IsSetMaxKeys()
        {
            return this.maxKeys.HasValue;
        }

        /// <summary>
        /// Gets the CommonPrefixes property. 
        /// A response can contain CommonPrefixes only if you specify a delimiter. 
        /// When you do, CommonPrefixes contains all (if there are any) keys between 
        /// Prefix and the next occurrence of the string specified by delimiter. In effect, 
        /// CommonPrefixes lists keys that act like subdirectories in the directory specified 
        /// by Prefix. For example, if prefix is notes/ and delimiter is a slash (/), in 
        /// notes/summer/july, the common prefix is notes/summer/.
        /// </summary>
        public List<string> CommonPrefixes
        {
            get { return this.commonPrefixes; }
            set { this.commonPrefixes = value; }
        }

        // Check to see if CommonPrefixes property is set
        internal bool IsSetCommonPrefixes()
        {
            return this.commonPrefixes.Count > 0;
        }

        /// <summary>
        /// Gets and sets the Delimiter property.
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection.
        /// </summary>
        /// <remarks>
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </remarks>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }
    }
}
    
