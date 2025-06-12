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

/*
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// You can configure the <c>DataResource</c> in an <c>EventSelector</c> to log data events
    /// for the following three resource types:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>AWS::DynamoDB::Table</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AWS::Lambda::Function</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AWS::S3::Object</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To log data events for all other resource types including objects stored in <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">directory
    /// buckets</a>, you must use <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelectors</a>.
    /// You must also use <c>AdvancedEventSelectors</c> if you want to filter on the <c>eventName</c>
    /// field.
    /// </para>
    ///  
    /// <para>
    /// Configure the <c>DataResource</c> to specify the resource type and resource ARNs for
    /// which you want to log data events.
    /// </para>
    ///  <note> 
    /// <para>
    /// The total number of allowed data resources is 250. This number can be distributed
    /// between 1 and 5 event selectors, but the total cannot exceed 250 across all selectors
    /// for the trail.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following example demonstrates how logging works when you configure logging of
    /// all data events for a general purpose bucket named <c>amzn-s3-demo-bucket1</c>. In
    /// this example, the CloudTrail user specified an empty prefix, and the option to log
    /// both <c>Read</c> and <c>Write</c> data events.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// A user uploads an image file to <c>amzn-s3-demo-bucket1</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>PutObject</c> API operation is an Amazon S3 object-level API. It is recorded
    /// as a data event in CloudTrail. Because the CloudTrail user specified an S3 bucket
    /// with an empty prefix, events that occur on any object in that bucket are logged. The
    /// trail processes and logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A user uploads an object to an Amazon S3 bucket named <c>arn:aws:s3:::amzn-s3-demo-bucket1</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>PutObject</c> API operation occurred for an object in an S3 bucket that the
    /// CloudTrail user didn't specify for the trail. The trail doesn’t log the event.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The following example demonstrates how logging works when you configure logging of
    /// Lambda data events for a Lambda function named <i>MyLambdaFunction</i>, but not for
    /// all Lambda functions.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// A user runs a script that includes a call to the <i>MyLambdaFunction</i> function
    /// and the <i>MyOtherLambdaFunction</i> function.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Invoke</c> API operation on <i>MyLambdaFunction</i> is an Lambda API. It is
    /// recorded as a data event in CloudTrail. Because the CloudTrail user specified logging
    /// data events for <i>MyLambdaFunction</i>, any invocations of that function are logged.
    /// The trail processes and logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Invoke</c> API operation on <i>MyOtherLambdaFunction</i> is an Lambda API.
    /// Because the CloudTrail user did not specify logging data events for all Lambda functions,
    /// the <c>Invoke</c> operation for <i>MyOtherLambdaFunction</i> does not match the function
    /// specified for the trail. The trail doesn’t log the event. 
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DataResource
    {
        private string _type;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type in which you want to log data events. You can specify the following
        /// <i>basic</i> event selector resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additional resource types are available through <i>advanced</i> event selectors. For
        /// more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/APIReference/API_AdvancedEventSelector.html">AdvancedEventSelector</a>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array of Amazon Resource Name (ARN) strings or partial ARN strings for the specified
        /// resource type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To log data events for all objects in all S3 buckets in your Amazon Web Services account,
        /// specify the prefix as <c>arn:aws:s3</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This also enables logging of data event activity performed by any user or role in
        /// your Amazon Web Services account, even if that activity is performed on a bucket that
        /// belongs to another Amazon Web Services account.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// To log data events for all objects in an S3 bucket, specify the bucket and an empty
        /// object prefix such as <c>arn:aws:s3:::amzn-s3-demo-bucket1/</c>. The trail logs data
        /// events for all objects in this S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To log data events for specific objects, specify the S3 bucket and object prefix such
        /// as <c>arn:aws:s3:::amzn-s3-demo-bucket1/example-images</c>. The trail logs data events
        /// for objects in this S3 bucket that match the prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To log data events for all Lambda functions in your Amazon Web Services account, specify
        /// the prefix as <c>arn:aws:lambda</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This also enables logging of <c>Invoke</c> activity performed by any user or role
        /// in your Amazon Web Services account, even if that activity is performed on a function
        /// that belongs to another Amazon Web Services account. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// To log data events for a specific Lambda function, specify the function ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// Lambda function ARNs are exact. For example, if you specify a function ARN <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld</i>,
        /// data events will only be logged for <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld</i>.
        /// They will not be logged for <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld2</i>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// To log data events for all DynamoDB tables in your Amazon Web Services account, specify
        /// the prefix as <c>arn:aws:dynamodb</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}