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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The Amazon S3 buckets or AWS Lambda functions that you specify in your event selectors
    /// for your trail to log data events. Data events provide insight into the resource operations
    /// performed on or within a resource itself. These are also known as data plane operations.
    /// You can specify up to 250 data resources for a trail.
    /// 
    ///  <note> 
    /// <para>
    /// The total number of allowed data resources is 250. This number can be distributed
    /// between 1 and 5 event selectors, but the total cannot exceed 250 across all selectors.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following example demonstrates how logging works when you configure logging of
    /// all data events for an S3 bucket named <code>bucket-1</code>. In this example, the
    /// CloudTrail user spcified an empty prefix, and the option to log both <code>Read</code>
    /// and <code>Write</code> data events.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// A user uploads an image file to <code>bucket-1</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>PutObject</code> API operation is an Amazon S3 object-level API. It is recorded
    /// as a data event in CloudTrail. Because the CloudTrail user specified an S3 bucket
    /// with an empty prefix, events that occur on any object in that bucket are logged. The
    /// trail processes and logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A user uploads an object to an Amazon S3 bucket named <code>arn:aws:s3:::bucket-2</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>PutObject</code> API operation occurred for an object in an S3 bucket that
    /// the CloudTrail user didn't specify for the trail. The trail doesn’t log the event.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The following example demonstrates how logging works when you configure logging of
    /// AWS Lambda data events for a Lambda function named <i>MyLambdaFunction</i>, but not
    /// for all AWS Lambda functions.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// A user runs a script that includes a call to the <i>MyLambdaFunction</i> function
    /// and the <i>MyOtherLambdaFunction</i> function.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Invoke</code> API operation on <i>MyLambdaFunction</i> is an AWS Lambda
    /// API. It is recorded as a data event in CloudTrail. Because the CloudTrail user specified
    /// logging data events for <i>MyLambdaFunction</i>, any invocations of that function
    /// are logged. The trail processes and logs the event. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Invoke</code> API operation on <i>MyOtherLambdaFunction</i> is an AWS Lambda
    /// API. Because the CloudTrail user did not specify logging data events for all Lambda
    /// functions, the <code>Invoke</code> operation for <i>MyOtherLambdaFunction</i> does
    /// not match the function specified for the trail. The trail doesn’t log the event. 
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DataResource
    {
        private string _type;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type in which you want to log data events. You can specify <code>AWS::S3::Object</code>
        /// or <code>AWS::Lambda::Function</code> resources.
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
        /// objects.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To log data events for all objects in all S3 buckets in your AWS account, specify
        /// the prefix as <code>arn:aws:s3:::</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This will also enable logging of data event activity performed by any user or role
        /// in your AWS account, even if that activity is performed on a bucket that belongs to
        /// another AWS account. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// To log data events for all objects in all S3 buckets that include <i>my-bucket</i>
        /// in their names, specify the prefix as <code>aws:s3:::my-bucket</code>. The trail logs
        /// data events for all objects in all buckets whose name contains a match for <i>my-bucket</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To log data events for all objects in an S3 bucket, specify the bucket and an empty
        /// object prefix such as <code>arn:aws:s3:::bucket-1/</code>. The trail logs data events
        /// for all objects in this S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To log data events for specific objects, specify the S3 bucket and object prefix such
        /// as <code>arn:aws:s3:::bucket-1/example-images</code>. The trail logs data events for
        /// objects in this S3 bucket that match the prefix.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To log data events for all functions in your AWS account, specify the prefix as <code>arn:aws:lambda</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This will also enable logging of <code>Invoke</code> activity performed by any user
        /// or role in your AWS account, even if that activity is performed on a function that
        /// belongs to another AWS account. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// To log data eents for a specific Lambda function, specify the function ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// Lambda function ARNs are exact. Unlike S3, you cannot use matching. For example, if
        /// you specify a function ARN <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld</i>,
        /// data events will only be logged for <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld</i>.
        /// They will not be logged for <i>arn:aws:lambda:us-west-2:111111111111:function:helloworld2</i>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}