/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Interface for Amazon S3 Clients.
    /// For more information about Amazon S3, go to <see href="http://aws.amazon.com/s3"/>
    /// </summary>
    public interface AmazonS3
    {
        /// <summary>
        /// The ListBuckets operation returns a list of all of the buckets
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        ListBucketsResponse ListBuckets();

        /// <summary>
        /// The ListBuckets operation returns a list of all of the buckets
        /// owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters 
        /// of this operation</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        ListBucketsResponse ListBuckets(ListBucketsRequest request);

        /// <summary>
        /// The GetBucketLocation operation takes in a bucket's name and lists the location
        /// of the bucket. This information can be used to determine the bucket's geographical
        /// location.
        /// To determine the location of a bucket, you must be the bucket owner.
        /// </summary>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request);

        /// <summary>
        /// The GetBucketLogging operating gets the logging status for the specified bucket.
        /// For more information about S3Bucket Logging,
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/ServerLogs.html"/>
        /// </summary>
        /// <param name="request">The GetBucketLoggingRequest that defines 
        /// the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request);

        /// <summary>
        /// The EnableBucketLogging operation will turn on bucket logging for the bucket
        /// defined in the request
        /// 
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </summary>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of 
        /// the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        /// <remarks>
        /// Changes to the logging status for a bucket are visible in the configuration API immediately, 
        /// but they take time to actually affect the delivery of log files. For example, if you enable 
        /// logging for a bucket, some requests made in the following hour might be logged, while others 
        /// might not. Or, if you change the target bucket for logging from bucket A to bucket B, some 
        /// logs for the next hour might continue to be delivered to bucket A, while others might be delivered 
        /// to the new target bucket B. In all cases, the new settings will eventually take effect without any 
        /// further action on your part. 
        /// </remarks>
        EnableBucketLoggingResponse EnableBucketLogging(EnableBucketLoggingRequest request);

        /// <summary>
        /// The DisableBucketLogging will turn off bucket logging for the bucket defined
        /// in the request.
        ///
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </summary>
        /// <param name="request">
        /// The DisableBucketLoggingRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        DisableBucketLoggingResponse DisableBucketLogging(DisableBucketLoggingRequest request);

        /// <summary>
        /// The GetBucketVersioning operation takes in a bucket's name and get the versioning
        /// status of the bucket.
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request);

        /// <summary>
        /// The SetBucketVersioning operation takes in a bucket's name and the versioning
        /// status you want to set on the bucket.
        /// <para>Valid values for the Versioning Status are Enabled and Suspended. 
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended" 
        /// but cannot be switched "Off".</para>
        /// </summary>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentException">
        /// If SetBucketVersioningRequest.VersioningStatus has the value S3BucketVersioningStatus.Off
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        SetBucketVersioningResponse SetBucketVersioning(SetBucketVersioningRequest request);

        /// <summary>
        /// The ListObjects operation lists the objects/keys in a bucket ordered
        /// lexicographically (from a-Z). The list can be filtered via the Marker
        /// property of the ListObjectsRequest.
        /// In order to List Objects, you must have READ access to the bucket.
        /// </summary>
        /// <param name="request">
        /// The ListObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3 with a list of S3Objects, 
        /// headers and request parameters used to filter the list.</returns>
        /// <remarks><para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete 
        /// results of a list query can be extremely large. To manage large result sets, 
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should 
        /// always check the <see cref="P:Amazon.S3.Model.ListObjectsResponse.IsTruncated" />
        /// to see if the returned listing 
        /// is complete, or if callers need to make additional calls to get more results.
        /// The marker parameter allows callers to specify where to start the object listing. 
        /// </para>
        /// List performance is not substantially affected by the total number of keys in your 
        /// bucket, nor by the presence or absence of any additional query parameters. 
        /// </remarks>
        ListObjectsResponse ListObjects(ListObjectsRequest request);

        /// <summary>
        /// The ListVersions operation returns a list of object versions in the bucket
        /// specified ordered first by key and then by version. Keys are sorted lexicographically
        /// (i.e. alphabetically from a-Z); versions are sorted from most to least recent.
        /// Both versions with data and delete markers are included in the results.
        /// <para>
        /// In order to List Versions, you must have READ access to the bucket.
        /// When the list is not filtered by a specific key, only the metadata
        /// associated with the latest version of objects in the bucket is returned. 
        /// The use of KeyMarker and VersionIdMarker allow you to filter results.</para>
        /// </summary>
        /// <param name="request">
        /// The ListVersionsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3 that contains a list of 
        /// versions along with metadata and the original request parameters.</returns>
        /// <remarks><para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete 
        /// results of a list query can be extremely large. To manage large result sets, 
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should 
        /// always check the <see cref="P:Amazon.S3.Model.ListVersionsResonse.IsTruncated" />
        /// to see if the returned listing 
        /// is complete, or if callers need to make additional calls to get more results.
        /// The KeyMarker and VersionIdMarker parameters of the ListVersionsRequest object
        /// allow callers to specify where to start the version listing. 
        /// </para>
        /// <para>In order to enable versioning on a bucket, please refer to the 
        /// <see cref="M:Amazon.S3.AmazonS3Client.SetBucketVersioning">SetBucketVersioning</see>
        /// operation's details.
        /// </para>
        /// List performance is not substantially affected by the total number of keys in your 
        /// bucket, nor by the presence or absence of any additional query parameters. 
        /// </remarks>
        ListVersionsResponse ListVersions(ListVersionsRequest request);

        /// <summary>
        /// The GetACL operation gets the S3AccessControlList for a given bucket or object.
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </summary>
        /// <param name="request">
        /// The GetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        GetACLResponse GetACL(GetACLRequest request);

        /// <summary>
        /// The SetACL operation gets the S3AccessControlList for a given bucket or object.
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </summary>
        /// <remarks>
        /// Often used ACLs are defined in the S3CannedACL enumeration.
        /// </remarks>
        /// <param name="request">
        /// The SetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        SetACLResponse SetACL(SetACLRequest request);

        /// <summary>
        /// The PutBucket operation creates a new S3 Bucket.
        /// Depending on your latency and legal requirements, you can specify a location
        /// constraint that will affect where your data physically resides.
        /// You can currently specify a Europe (EU) location constraint.
        /// </summary>
        /// <param name="request">
        /// The PutBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        /// <remarks><para>
        /// Every object stored in Amazon S3 is contained in a bucket. Buckets 
        /// partition the namespace of objects stored in Amazon S3 at the top level. 
        /// Within a bucket, you can use any names for your objects, but bucket names 
        /// must be unique across all of Amazon S3.
        /// </para><para>
        /// Buckets are similar to Internet domain names. Just as Amazon is the only owner 
        /// of the domain name Amazon.com, only one person or organization can own a bucket 
        /// within Amazon S3. The similarities between buckets and domain names is not a 
        /// coincidence - there is a direct mapping between Amazon S3 buckets and subdomains 
        /// of s3.amazonaws.com. Objects stored in Amazon S3 are addressable using the REST API 
        /// under the domain bucketname.s3.amazonaws.com. For example, the object homepage.html 
        /// stored in the Amazon S3 bucket mybucket can be addressed as 
        /// http://mybucket.s3.amazonaws.com/homepage.html.
        ///</para><para>
        /// To conform with DNS requirements, the following constraints apply:
        /// <list type="bullet">
        /// <item>Bucket names should not contain underscores (_)</item>
        /// <item>Bucket names should be between 3 and 63 characters long</item>
        /// <item>Bucket names should not end with a dash</item>
        /// <item>Bucket names cannot contain two, adjacent periods</item>
        /// <item>Bucket names cannot contain dashes next to periods
        ///   (e.g., "my-.bucket.com" and "my.-bucket" are invalid)</item>
        /// <item>Bucket names cannot contain uppercase characters</item>
        /// </list></para>
        /// There is no limit to the number of objects that can be stored in a bucket and no 
        /// variation in performance when using many buckets or just a few. You can store all 
        /// of your objects in a single bucket or organize them across several buckets.
        /// </remarks>
        PutBucketResponse PutBucket(PutBucketRequest request);

        /// <summary>
        /// The DeleteBucket operation deletes the bucket named in the request.
        /// All objects in the bucket must be deleted before the bucket itself can be deleted.
        /// Only the owner of a bucket can delete it, regardless of the bucket's access control policy.
        /// </summary>
        /// <param name="request">
        /// The DeleteBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        DeleteBucketResponse DeleteBucket(DeleteBucketRequest request);

        /// <summary>
        /// The GetObject operation fetches the most recent version of an S3 object 
        /// from the specified S3 bucket. You must have READ access to the object. 
        /// If READ access is granted to an anonymous user, an object can be retrieved 
        /// without an authorization header. Providing a version-id for the object will 
        /// fetch the specific version from S3 instead of the most recent one.
        /// </summary>
        /// <param name="request">
        /// The GetObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        /// <remarks>
        /// Please wrap the response you get from calling GetObject in a using clause.
        /// This ensures that all underlying IO resources allocated for the response
        /// are disposed once the response has been processed. This is one way to
        /// call GetObject:
        /// <code>
        /// using (GetObjectResponse response = s3Client.GetObject(request))
        /// {
        ///     ... Process the response: 
        ///     Get the Stream, get the content-length, write contents to disk, etc
        /// }
        /// </code>
        /// To see what resources are cleaned up at the end of the using block, please 
        /// see <see cref="M:Amazon.S3.Model.S3Response.Dispose"/>
        /// </remarks>
        GetObjectResponse GetObject(GetObjectRequest request);

        /// <summary>
        /// The GetObjectMetadata operation is used to retrieve information about a specific object
        /// or object size, without actually fetching the object itself. This is useful if you're
        /// only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </summary>
        /// <param name="request">
        /// The GetObjectMetadataRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request);

        /// <summary>
        /// The PutObject operation adds an object to an S3 Bucket.
        /// The response indicates that the object has been successfully stored.
        /// Amazon S3 never stores partial objects: if you receive a successful
        /// response, then you can be confident that the entire object was stored.
        ///
        /// To ensure data is not corrupted over the network, use the Content-MD5
        /// header. When you use the Content-MD5 header, Amazon S3 checks the object
        /// against the provided MD5 value. If they do not match, Amazon S3 returns an error.
        /// Additionally, you can calculate the MD5 while putting an object to
        /// Amazon S3 and compare the returned Etag to the calculated MD5 value.
        ///
        /// If an object already exists in a bucket, the new object will overwrite
        /// it because Amazon S3 stores the last write request. However, Amazon S3
        /// is a distributed system. If Amazon S3 receives multiple write requests
        /// for the same object nearly simultaneously, all of the objects might be
        /// stored, even though only one wins in the end. Amazon S3 does not provide
        /// object locking; if you need this, make sure to build it into your application
        /// layer.
        ///
        /// If you specify a location constraint when creating a bucket, all objects
        /// added to the bucket are stored in the bucket's location.
        ///
        /// You must have WRITE access to the bucket to add an object.
        /// </summary>
        /// <param name="request">
        /// The PutObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:System.IO.FileNotFoundException"></exception>
        /// <returns>Returns a PutObjectResponse from S3.</returns>
        PutObjectResponse PutObject(PutObjectRequest request);

        /// <summary>
        /// The DeleteObject operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete an object.
        ///
        /// If you delete an object that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </summary>
        /// <param name="request">
        /// The DeleteObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        DeleteObjectResponse DeleteObject(DeleteObjectRequest request);

        /// <summary>
        /// The copy operation creates a copy of an object that is already stored in Amazon S3.
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// If versioning has been enabled on the source bucket, and you want to copy a specific
        /// version of an object, please use 
        /// <see cref="P:Amazon.S3.Model.CopyObjectRequest.SourceVersionId" /> to specify the 
        /// version. By default, the most recent version of an object is copied to the 
        /// destination bucket.
        /// </summary>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        /// <remarks>
        /// If Versioning has been enabled on the target bucket, S3 generates a 
        /// unique version ID for the object being copied. This version ID is different 
        /// from the version ID of the source object. Additionally, S3 returns the version 
        /// ID of the copied object in the x-amz-version-id response header in the response.
        /// If you do not enable Versioning or suspend it on the target bucket, the version ID 
        /// S3 generates is always the string literal - "null". 
        /// </remarks>
        CopyObjectResponse CopyObject(CopyObjectRequest request);

        /// <summary>
        /// The GetPreSignedURL operations creates a signed http request.
        /// Query string authentication is useful for giving HTTP or browser
        /// access to resources that would normally require authentication.
        /// When using query string authentication, you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// A PreSigned URL can be generated for GET, PUT and HEAD
        /// operations on your bucket.
        /// </summary>
        /// <param name="request">The GetPreSignedUrlRequest that defines the parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        string GetPreSignedURL(GetPreSignedUrlRequest request);
    }
}