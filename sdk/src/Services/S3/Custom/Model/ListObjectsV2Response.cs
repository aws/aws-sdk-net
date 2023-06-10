/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private List<string> commonPrefixes = new List<string>();
        private List<S3Object> contents = new List<S3Object>();
        private string continuationToken;
        private string delimiter;
        private EncodingType encoding;
        private bool? isTruncated;
        private int? keyCount;
        private int? maxKeys;
        private string name;
        private string nextContinuationToken;
        private string prefix;
        private string startAfter;

        /// <summary>
        /// Gets and sets the property CommonPrefixes. 
        /// <para>
        /// All of the keys (up to 1,000) rolled up into a common prefix count as a single return
        /// when calculating the number of returns.
        /// </para>
        ///  
        /// <para>
        /// A response can contain <code>CommonPrefixes</code> only if you specify a delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <code>CommonPrefixes</code> contains all (if there are any) keys between <code>Prefix</code>
        /// and the next occurrence of the string specified by a delimiter.
        /// </para>
        ///  
        /// <para>
        ///  <code>CommonPrefixes</code> lists keys that act like subdirectories in the directory
        /// specified by <code>Prefix</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, if the prefix is <code>notes/</code> and the delimiter is a slash (<code>/</code>)
        /// as in <code>notes/summer/july</code>, the common prefix is <code>notes/summer/</code>.
        /// All of the keys that roll up into a common prefix count as a single return when calculating
        /// the number of returns. 
        /// </para>
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
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Causes keys that contain the same string between the prefix and the first occurrence
        /// of the delimiter to be rolled up into a single result element in the CommonPrefixes
        /// collection. These rolled-up keys are not returned elsewhere in the response. Each
        /// rolled-up result counts as only one return against the <code>MaxKeys</code> value.
        /// </para>
        /// </summary>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Encoding type used by Amazon S3 to encode object keys in the response.
        /// <para>
        /// Encoding type used by Amazon S3 to encode object key names in the XML response.
        /// </para>
        ///  
        /// <para>
        /// If you specify the encoding-type request parameter, Amazon S3 includes this element
        /// in the response, and returns encoded key name values in the following response elements:
        /// </para>
        ///  
        /// <para>
        ///  <code>Delimiter, Prefix, Key,</code> and <code>StartAfter</code>.
        /// </para>
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Set to false if all of the results were returned. Set to true if more keys are available
        /// to return. If the number of results exceeds that specified by MaxKeys, all of the
        /// results might not be returned.
        /// </para>
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
        /// Gets and sets the property KeyCount. 
        /// <para>
        /// KeyCount is the number of keys returned with this request. KeyCount will always be
        /// less than or equal to the <code>MaxKeys</code> field. Say you ask for 50 keys, your
        /// result will include 50 keys or fewer.
        /// </para>
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
        /// Gets and sets the property MaxKeys. 
        /// <para>
        /// Sets the maximum number of keys returned in the response. By default the action returns
        /// up to 1,000 key names. The response might contain fewer keys but will never contain
        /// more.
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The bucket name.
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
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
        /// Gets and sets the property NextContinuationToken. 
        /// <para>
        ///  <code>NextContinuationToken</code> is sent when <code>isTruncated</code> is true,
        /// which means there are more keys in the bucket that can be listed. The next list requests
        /// to Amazon S3 can be continued with this <code>NextContinuationToken</code>. <code>NextContinuationToken</code>
        /// is obfuscated and is not a real key
        /// </para>
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
        /// Gets and sets the property Prefix. 
        /// <para>
        ///  Keys that begin with the indicated prefix.
        /// </para>
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
        /// Gets and sets the property StartAfter. 
        /// <para>
        /// If StartAfter was sent with the request, it is included in the response.
        /// </para>
        /// </summary>
        public string StartAfter
        {
            get { return this.startAfter; }
            set { this.startAfter = value; }
        }

        // Check to see if StartAfter property is set
        internal bool IsSetStartAfter()
        {
            return this.startAfter != null;
        }
    }
}
    
