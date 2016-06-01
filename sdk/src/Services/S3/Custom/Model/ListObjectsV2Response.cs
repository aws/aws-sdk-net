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
    public class ListObjectsV2Response : AmazonWebServiceResponse
    {
        private bool? isTruncated;
        private List<S3Object> contents = new List<S3Object>();
        private string name;
        private string prefix;
        private string delimiter;
        private int? maxKeys;
        private List<string> commonPrefixes = new List<string>();
        private EncodingType encoding;
        private int? keyCount;
        private string continuationToken;
        private string nextContinuationToken;
        private string startAfter;

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
        /// Gets and sets the S3Objects property. Metadata about each object returned.
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
        /// Gets and sets the Name property. The name of the bucket that was listed.
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
        /// Gets and sets the CommonPrefixes property.
        /// CommonPrefixes contains all (if there are any) keys between Prefix and the next occurrence 
        /// of the string specified by delimiter
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

        /// <summary>
        /// Encoding type used by Amazon S3 to encode object keys in the response.
        /// </summary>
        public EncodingType Encoding
        {
            get { return this.encoding; }
            set { this.encoding = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetEncoding()
        {
            return this.encoding != null;
        }


        /// <summary>
        /// KeyCount is the number of keys returned with this request.
        /// KeyCount will always be less than or equal to MaxKeys field.
        /// </summary>
        public int KeyCount
        {
            get { return this.keyCount ?? default(int); }
            set { this.keyCount = value; }
        }
        // Check to see if KeyCount property is set
        internal bool IsSetKeyCount()
        {
            return this.keyCount.HasValue;
        }

        /// <summary>
        /// ContinuationToken indicates Amazon S3 that the list is being continued
        /// on this bucket with a token.
        /// ContinuationToken is obfuscated and is not a real key
        /// </summary>
        public string ContinuationToken
        {
            get { return this.continuationToken; }
            set { this.continuationToken = value; }
        }
        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this.continuationToken != null;
        }

        /// <summary>
        /// NextContinuationToken is sent when isTruncated is true which means there
        /// are more keys in the bucket that can be listed. The next ListObjectV2 call
        /// to Amazon S3 can be continued with this NextContinuationToken.
        /// NextContinuationToken is obfuscated and is not a real key.
        /// </summary>
        public string NextContinuationToken
        {
            get { return this.nextContinuationToken; }
            set { this.nextContinuationToken = value; }
        }
        // Check to see if NextContinuationToken property is set
        internal bool IsSetNextContinuationToken()
        {
            return this.nextContinuationToken != null;
        }

        /// <summary>
        /// StartAfter is where you want Amazon S3 to start listing from.
        /// Amazon S3 starts listing after this specified key.
        /// StartAfter can be any key in the bucket.
        /// </summary>
        public string StartAfter
        {
            get { return this.startAfter; }
            set { this.startAfter = value; }
        }
        // Check to see if StartKey property is set
        internal bool IsSetStartAfter()
        {
            return this.startAfter != null;
        }
    }
}
    
