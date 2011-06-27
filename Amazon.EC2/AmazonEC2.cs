/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-05-15
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// The Amazon Elastic Compute Cloud (Amazon EC2) web
    /// service provides you with
    /// the ability to execute your applications in
    /// Amazon's computing environment.
    /// To use Amazon EC2 you simply:
    /// 1. Create an Amazon Machine Image (AMI) containing all your software,
    /// including your operating system and associated configuration settings,
    /// applications, libraries, etc. Think of this as zipping up the contents
    /// of your hard drive. We provide all the necessary tools to create and
    /// package your AMI.
    /// 2. Upload this AMI to the Amazon S3 (Amazon Simple
    /// Storage Service) service. This gives us reliable,
    /// secure access to your AMI.
    /// 3. Register your AMI with Amazon EC2. This allows us to verify
    /// that your AMI has been uploaded correctly and to allocate a unique
    /// identifier for it.
    /// 4. Use this AMI ID and the Amazon EC2 web service
    /// APIs to run, monitor, and
    /// terminate as many instances of this AMI as
    /// required.
    /// You can also skip the first three steps and choose to launch
    /// an AMI that is provided by Amazon or shared by another user.
    /// While instances are running, you are billed for the computing
    /// and network resources that they consume.
    /// You can also skip the first three steps
    /// and choose to launch an AMI that is
    /// provided by Amazon or shared by
    /// another user.
    /// While instances are running, you are billed for the
    /// computing and network
    /// resources that they consume.
    /// </summary>
    public interface AmazonEC2 : IDisposable
    {
        /// <summary>
        /// Activate License 
        /// </summary>
        /// <param name="request">Activate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Activate License  Response from the service</returns>
        /// <remarks>
        /// Activates a specific number of licenses for a 90-day period.
        /// Activations can be done against a specific license ID.
        /// </remarks>
        ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request);

        /// <summary>
        /// Allocate Address 
        /// </summary>
        /// <param name="request">Allocate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Allocate Address  Response from the service</returns>
        /// <remarks>
        /// The AllocateAddress operation acquires an elastic
        /// IP address for use with your account.
        /// </remarks>
        AllocateAddressResponse AllocateAddress(AllocateAddressRequest request);

        /// <summary>
        /// Associate Address 
        /// </summary>
        /// <param name="request">Associate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Address  Response from the service</returns>
        /// <remarks>
        /// The AssociateAddress operation associates an
        /// elastic IP address with an instance.
        /// If the IP address is currently
        /// assigned to another instance, the IP
        /// address is assigned to the new
        /// instance. This is an idempotent operation. If you enter
        /// it more than once, Amazon EC2 does not return an error.
        /// </remarks>
        AssociateAddressResponse AssociateAddress(AssociateAddressRequest request);

        /// <summary>
        /// Attach Volume 
        /// </summary>
        /// <param name="request">Attach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Volume  Response from the service</returns>
        /// <remarks>
        /// Attach a previously created volume to a running
        /// instance.
        /// </remarks>
        AttachVolumeResponse AttachVolume(AttachVolumeRequest request);

        /// <summary>
        /// Authorize Security Group Ingress 
        /// </summary>
        /// <param name="request">Authorize Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// The AuthorizeSecurityGroupIngress operation adds
        /// permissions to a security group.
        /// Permissions are specified by the IP
        /// protocol (TCP, UDP or ICMP), the source of
        /// the request (by IP range
        /// or an Amazon EC2 user-group pair), the
        /// source and destination port ranges (for TCP and UDP),
        /// and the ICMP codes and types (for ICMP).
        /// When authorizing ICMP, -1 can be used as a wildcard in the
        /// type and code fields.
        /// Permission changes are propagated to instances within the
        /// security group as quickly as possible. However, depending on the
        /// number of instances, a small
        /// delay might occur.
        /// When authorizing a user/group pair permission, GroupName,
        /// SourceSecurityGroupName and
        /// SourceSecurityGroupOwnerId must be
        /// specified. When authorizing a CIDR
        /// IP permission, GroupName, IpProtocol, FromPort, ToPort and
        /// CidrIp must be specified. Mixing these two types of parameters is
        /// not allowed.
        /// </remarks>
        AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);

        /// <summary>
        /// Bundle Instance 
        /// </summary>
        /// <param name="request">Bundle Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Bundle Instance  Response from the service</returns>
        /// <remarks>
        /// The BundleInstance operation request that an
        /// instance is bundled the next time it boots.
        /// The bundling process creates a new image from a running instance and
        /// stores the AMI data in S3. Once bundled, the image must be registered in the
        /// normal way using the RegisterImage API.
        /// </remarks>
        BundleInstanceResponse BundleInstance(BundleInstanceRequest request);

        /// <summary>
        /// Cancel Bundle Task 
        /// </summary>
        /// <param name="request">Cancel Bundle Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Bundle Task  Response from the service</returns>
        /// <remarks>
        /// CancelBundleTask operation cancels a pending or
        /// in-progress bundling task. This is an asynchronous
        /// call and it make
        /// take a while for the task to be cancelled.
        /// If a task is cancelled
        /// while it is storing items,
        /// there may be parts of the incomplete AMI
        /// stored in S3.
        /// It is up to the caller to clean up these parts from S3.
        /// </remarks>
        CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request);

        /// <summary>
        /// Confirm Product Instance 
        /// </summary>
        /// <param name="request">Confirm Product Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Confirm Product Instance  Response from the service</returns>
        /// <remarks>
        /// The ConfirmProductInstance operation returns true
        /// if the specified product code
        /// is attached to the specified instance.
        /// The operation returns false if the
        /// product code is not attached to the
        /// instance.
        /// The ConfirmProductInstance operation can only be executed
        /// by the owner of the
        /// AMI. This feature is useful when an AMI owner is
        /// providing support and wants to
        /// verify whether a user's instance is eligible.
        /// </remarks>
        ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request);

        /// <summary>
        /// Create Image 
        /// </summary>
        /// <param name="request">Create Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Image  Response from the service</returns>
        /// <remarks>
        /// Creates an AMI that uses an Amazon EBS root
        /// device from a "running" or "stopped" instance.
        /// AMIs that use an Amazon EBS root device boot
        /// faster than AMIs that use instance stores. They
        /// can be up to 1 TiB in size, use storage that
        /// persists on instance failure, and can be stopped and started.
        /// </remarks>
        CreateImageResponse CreateImage(CreateImageRequest request);

        /// <summary>
        /// Create Key Pair 
        /// </summary>
        /// <param name="request">Create Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Key Pair  Response from the service</returns>
        /// <remarks>
        /// The CreateKeyPair operation creates a new 2048
        /// bit RSA key pair and returns a
        /// unique ID that can be used to reference
        /// this key pair when launching new
        /// instances. For more information, see
        /// RunInstances.
        /// </remarks>
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);

        /// <summary>
        /// Create Placement Group 
        /// </summary>
        /// <param name="request">Create Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Placement Group  Response from the service</returns>
        /// <remarks>
        /// The CreateKeyPair operation creates a new 2048
        /// bit RSA key pair and returns a
        /// unique ID that can be used to reference
        /// this key pair when launching new
        /// instances. For more information, see
        /// RunInstances.
        /// </remarks>
        CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request);

        /// <summary>
        /// Create Security Group 
        /// </summary>
        /// <param name="request">Create Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Security Group  Response from the service</returns>
        /// <remarks>
        /// The CreateSecurityGroup operation creates a new
        /// security group.
        /// Every instance is launched in a security group. If no security group is
        /// specified during launch, the instances are launched in the default
        /// security group. Instances within the same security
        /// group have unrestricted network access to each other. Instances will
        /// reject network access attempts from other instances in a different
        /// security group. As the owner of instances you can grant or revoke
        /// specific permissions using the AuthorizeSecurityGroupIngress
        /// and RevokeSecurityGroupIngress operations.
        /// </remarks>
        CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);

        /// <summary>
        /// Create Snapshot 
        /// </summary>
        /// <param name="request">Create Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Snapshot  Response from the service</returns>
        /// <remarks>
        /// Create a snapshot of the volume identified by
        /// volume ID. A volume does not have to be detached
        /// at the time the snapshot is taken.
        /// Important Note:
        /// Snapshot creation requires that the
        /// system is in a consistent state.
        /// For instance, this means that if
        /// taking a snapshot of a database, the
        /// tables must be read-only locked
        /// to ensure that the snapshot will not contain a
        /// corrupted version of the database. Therefore,
        /// be careful when using this API to ensure that
        /// the system remains in the consistent state until the create
        /// snapshot status has returned.
        /// </remarks>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Create Tags 
        /// </summary>
        /// <param name="request">Create Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Tags  Response from the service</returns>
        /// <remarks>
        /// Adds or overwrites one or more tags for the specified resource or 
        /// resources. Each resource can have a maximum of 10 tags. Each tag consists 
        /// of a key and optional value. Tag keys must be unique per resource.
        /// </remarks>
        CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Create Volume 
        /// </summary>
        /// <param name="request">Create Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Volume  Response from the service</returns>
        /// <remarks>
        /// Initializes an empty volume of a given size
        /// </remarks>
        CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Deactivate License 
        /// </summary>
        /// <param name="request">Deactivate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deactivate License  Response from the service</returns>
        /// <remarks>
        /// Deactivates a specific number of licenses.
        /// Deactivations can be done against a specific license ID
        /// after they have persisted for at least a 90-day period.
        /// </remarks>
        DeactivateLicenseResponse DeactivateLicense(DeactivateLicenseRequest request);

        /// <summary>
        /// Delete Key Pair 
        /// </summary>
        /// <param name="request">Delete Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Key Pair  Response from the service</returns>
        /// <remarks>
        /// The DeleteKeyPair operation deletes a key pair.
        /// </remarks>
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);

        /// <summary>
        /// Delete Placement Group 
        /// </summary>
        /// <param name="request">Delete Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Placement Group  Response from the service</returns>
        /// <remarks>
        /// The DeletePlacementGroup operation deletes a placement group.
        /// </remarks>
        DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request);

        /// <summary>
        /// Delete Security Group 
        /// </summary>
        /// <param name="request">Delete Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Security Group  Response from the service</returns>
        /// <remarks>
        /// The DeleteSecurityGroup operation deletes a
        /// security group.
        /// Note:
        /// If you attempt to delete a security group that
        /// contains instances, a fault is returned.
        /// If you attempt to delete a
        /// security group that is referenced by
        /// another security group, a fault
        /// is returned. For example, if security group B has a
        /// rule that allows access from security group A, security group A
        /// cannot be deleted until the allow rule is removed.
        /// </remarks>
        DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);

        /// <summary>
        /// Delete Snapshot 
        /// </summary>
        /// <param name="request">Delete Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Snapshot  Response from the service</returns>
        /// <remarks>
        /// Deletes the snapshot identitied by snapshotId.
        /// </remarks>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Delete Tags 
        /// </summary>
        /// <param name="request">Delete Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Tags  Response from the service</returns>
        /// <remarks>
        /// Deletes the snapshot identitied by snapshotId.
        /// </remarks>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Delete Volume 
        /// </summary>
        /// <param name="request">Delete Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Volume  Response from the service</returns>
        /// <remarks>
        /// Deletes a previously created volume. Once
        /// successfully deleted, a new
        /// volume can be created with the same name.
        /// </remarks>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Deregister Image 
        /// </summary>
        /// <param name="request">Deregister Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deregister Image  Response from the service</returns>
        /// <remarks>
        /// The DeregisterImage operation deregisters an AMI.
        /// Once deregistered, instances
        /// of the AMI can no longer be launched.
        /// </remarks>
        DeregisterImageResponse DeregisterImage(DeregisterImageRequest request);

        /// <summary>
        /// Describe Addresses 
        /// </summary>
        /// <param name="request">Describe Addresses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Addresses  Response from the service</returns>
        /// <remarks>
        /// The DescribeAddresses operation lists elastic IP
        /// addresses assigned to your account.
        /// </remarks>
        DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request);

        /// <summary>
        /// Describe Availability Zones 
        /// </summary>
        /// <param name="request">Describe Availability Zones  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Availability Zones  Response from the service</returns>
        /// <remarks>
        /// The DescribeAvailabilityZones operation describes
        /// availability zones that are
        /// currently available to the account and
        /// their states.
        /// Availability zones are not the same across accounts.
        /// The availability zone
        /// us-east-1a for account A is not necessarily the
        /// same as us-east-1a for account
        /// B. Zone assignments are mapped
        /// independently for each account.
        /// </remarks>
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request);

        /// <summary>
        /// Describe Bundle Tasks 
        /// </summary>
        /// <param name="request">Describe Bundle Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Bundle Tasks  Response from the service</returns>
        /// <remarks>
        /// The DescribeBundleTasks operation describes in-progress
        /// and recent bundle tasks. Complete and failed tasks are
        /// removed from the list a short time after completion.
        /// If no bundle ids are given, all bundle tasks are returned.
        /// </remarks>
        DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request);

        /// <summary>
        /// Describe Licenses 
        /// </summary>
        /// <param name="request">Describe Licenses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Licenses  Response from the service</returns>
        /// <remarks>
        /// Provides details of a user's registered licenses. Zero or more IDs
        /// may be specified on the call. When one or more license IDs are
        /// specified, only data for the specified IDs are returned.
        /// </remarks>
        DescribeLicensesResponse DescribeLicenses(DescribeLicensesRequest request);

        /// <summary>
        /// Describe Placement Groups 
        /// </summary>
        /// <param name="request">Describe Placement Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Placement Groups  Response from the service</returns>
        /// <remarks>
        /// Returns information about one or more PlacementGroup instances in a
        /// user's account.
        /// </remarks>
        DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request);

        /// <summary>
        /// Describe Snapshot Attribute 
        /// </summary>
        /// <param name="request">Describe Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Returns information about an attribute of a snapshot.
        /// Only one attribute can be specified per call.
        /// </remarks>
        DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request);

        /// <summary>
        /// Describe Image Attribute 
        /// </summary>
        /// <param name="request">Describe Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The DescribeImageAttribute operation returns
        /// information about an attribute of
        /// an AMI. Only one attribute can be
        /// specified per call.
        /// </remarks>
        DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request);

        /// <summary>
        /// Describe Images 
        /// </summary>
        /// <param name="request">Describe Images  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Images  Response from the service</returns>
        /// <remarks>
        /// The DescribeImages operation returns information
        /// about AMIs, AKIs, and ARIs
        /// available to the user. Information returned
        /// includes image type, product codes,
        /// architecture, and kernel and RAM
        /// disk IDs. Images available to the user include
        /// public images
        /// available for any user to launch, private images owned
        /// by the user making the request, and private images
        /// owned by other users for which the
        /// user has explicit launch permissions.
        /// Launch permissions fall into three categories:
        /// Public:
        /// The owner of the AMI granted launch permissions for the AMI to the all
        /// group. All users have launch permissions for these AMIs.
        /// Explicit:
        /// The owner of the AMI granted launch permissions to a specific user.
        /// Implicit:
        /// A user has implicit launch permissions for all AMIs he or she owns.
        /// The list of AMIs returned can be modified by specifying AMI IDs, AMI
        /// owners, or users with launch permissions. If no options are specified,
        /// Amazon EC2 returns all AMIs for which the user has launch permissions.
        /// If you specify one or more AMI IDs, only AMIs that have the specified
        /// IDs are returned. If you specify an invalid AMI ID, a fault is returned.
        /// If you specify an AMI ID for which you do not have access, it will not
        /// be included in the returned results.
        /// If you specify one or more AMI
        /// owners, only AMIs from the specified
        /// owners and for which you have
        /// access are returned. The results can include the
        /// account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own.
        /// If you specify a list of executable users, only users
        /// that have launch
        /// permissions for the AMIs are returned. You can
        /// specify account IDs
        /// (if you own
        /// the AMI(s)), self for AMIs for which
        /// you own or have explicit
        /// permissions, or
        /// all for public AMIs.
        /// Note:
        /// Deregistered images are included in the returned results for an
        /// unspecified
        /// interval after deregistration.
        /// </remarks>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Describe Instances 
        /// </summary>
        /// <param name="request">Describe Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instances  Response from the service</returns>
        /// <remarks>
        /// The DescribeInstances operation returns
        /// information about instances that you own.
        /// If you specify one or more instance IDs, Amazon EC2 returns
        /// information for those instances. If you do not specify
        /// instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an invalid
        /// instance ID, a fault is returned. If you specify an instance
        /// that you do not own, it will
        /// not be included in the returned results.
        /// Recently terminated instances might appear in the
        /// returned results. This interval is usually less than one hour.
        /// </remarks>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Describe Regions 
        /// </summary>
        /// <param name="request">Describe Regions  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Regions  Response from the service</returns>
        /// <remarks>
        /// The DescribeRegions operation describes regions
        /// zones that are
        /// currently available to the account.
        /// </remarks>
        DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request);

        /// <summary>
        /// Describe Reserved Instances 
        /// </summary>
        /// <param name="request">Describe Reserved Instances  request</param>
        /// <returns>Describe Reserved Instances  Response from the service</returns>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <remarks>
        /// The DescribeReservedInstances operation describes
        /// Reserved Instances
        /// that were purchased for use with your account.
        /// </remarks>
        DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request);

        /// <summary>
        /// Describe Reserved Instances Offerings 
        /// </summary>
        /// <param name="request">Describe Reserved Instances Offerings  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Reserved Instances Offerings  Response from the service</returns>
        /// <remarks>
        /// The DescribeReservedInstancesOfferings operation
        /// describes Reserved
        /// Instance offerings that are available for
        /// purchase. With Amazon EC2
        /// Reserved Instances, you purchase the right
        /// to launch Amazon EC2 instances
        /// for a period of time (without getting
        /// insufficient capacity errors) and
        /// pay a lower usage rate for the
        /// actual time used.
        /// </remarks>
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Describe Key Pairs 
        /// </summary>
        /// <param name="request">Describe Key Pairs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Key Pairs  Response from the service</returns>
        /// <remarks>
        /// The DescribeKeyPairs operation returns information about key pairs
        /// available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise,
        /// information for all registered key pairs is returned.
        /// </remarks>
        DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request);

        /// <summary>
        /// Describe Security Groups 
        /// </summary>
        /// <param name="request">Describe Security Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Security Groups  Response from the service</returns>
        /// <remarks>
        /// The DescribeSecurityGroups operation returns
        /// information about security groups
        /// that you own.
        /// If you specify security group names, information about those security
        /// group is returned. Otherwise, information for all security group is
        /// returned. If you specify a group that does not exist, a fault is returned.
        /// </remarks>
        DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Describe Snapshots 
        /// </summary>
        /// <param name="request">Describe Snapshots  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshots  Response from the service</returns>
        /// <remarks>
        /// Describes the indicated snapshots, or in lieu of
        /// that, all snapshots owned by the caller.
        /// </remarks>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Describe Tags 
        /// </summary>
        /// <param name="request">Describe Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Tags  Response from the service</returns>
        /// <remarks>
        /// Describes the indicated snapshots, or in lieu of
        /// that, all snapshots owned by the caller.
        /// </remarks>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Describe Volumes 
        /// </summary>
        /// <param name="request">Describe Volumes  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volumes  Response from the service</returns>
        /// <remarks>
        /// Describes the status of the indicated or, in lieu
        /// of any specified, all
        /// volumes belonging to the caller.
        /// Volumes that
        /// have been deleted are not described.
        /// </remarks>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Detach Volume 
        /// </summary>
        /// <param name="request">Detach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Volume  Response from the service</returns>
        /// <remarks>
        /// Detach a previously attached volume from a
        /// running instance.
        /// </remarks>
        DetachVolumeResponse DetachVolume(DetachVolumeRequest request);

        /// <summary>
        /// Disassociate Address 
        /// </summary>
        /// <param name="request">Disassociate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Address  Response from the service</returns>
        /// <remarks>
        /// The DisassociateAddress operation disassociates
        /// the specified elastic IP
        /// address from the instance to which it is
        /// assigned. This is an idempotent
        /// operation. If you enter it more than
        /// once, Amazon EC2 does not
        /// return an error.
        /// </remarks>
        DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request);

        /// <summary>
        /// Get Password Data 
        /// </summary>
        /// <param name="request">Get Password Data  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Password Data  Response from the service</returns>
        /// <remarks>
        /// Retrieves the encrypted administrator password
        /// for the instances running
        /// Windows.
        /// </remarks>
        GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request);

        /// <summary>
        /// Get Console Output 
        /// </summary>
        /// <param name="request">Get Console Output  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Console Output  Response from the service</returns>
        /// <remarks>
        /// The GetConsoleOutput operation retrieves console
        /// output for the specified instance.
        /// Instance console output is buffered
        /// and posted shortly after instance boot,
        /// reboot, and termination. Amazon EC2 preserves the
        /// most recent 64 KB output which will be
        /// available for at least one hour after the most recent post.
        /// </remarks>
        GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request);

        /// <summary>
        /// Import Key Pair 
        /// </summary>
        /// <param name="request">Import Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Key Pair  Response from the service</returns>
        /// <remarks>
        /// The GetConsoleOutput operation retrieves console
        /// output for the specified instance.
        /// Instance console output is buffered
        /// and posted shortly after instance boot,
        /// reboot, and termination. Amazon EC2 preserves the
        /// most recent 64 KB output which will be
        /// available for at least one hour after the most recent post.
        /// </remarks>
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);

        /// <summary>
        /// Modify Snapshot Attribute 
        /// </summary>
        /// <param name="request">Modify Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Adds or remove permission settings for the
        /// specified snapshot.
        /// </remarks>
        ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request);

        /// <summary>
        /// Modify Image Attribute 
        /// </summary>
        /// <param name="request">Modify Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The ModifyImageAttribute operation modifies an
        /// attribute of an AMI.
        /// </remarks>
        ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request);

        /// <summary>
        /// Purchase Reserved Instances Offering 
        /// </summary>
        /// <param name="request">Purchase Reserved Instances Offering  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Purchase Reserved Instances Offering  Response from the service</returns>
        /// <remarks>
        /// The PurchaseReservedInstancesOffering operation
        /// purchases a Reserved Instance for use with your account.
        /// With Amazon EC2 Reserved Instances, you purchase the
        /// right to launch Amazon EC2 instances for a period of time
        /// (without getting insufficient capacity errors) and pay a
        /// lower usage rate for the actual time used.
        /// </remarks>
        PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request);

        /// <summary>
        /// Reboot Instances 
        /// </summary>
        /// <param name="request">Reboot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reboot Instances  Response from the service</returns>
        /// <remarks>
        /// The RebootInstances operation requests a reboot
        /// of one or more instances. This
        /// operation is asynchronous; it only
        /// queues a request to reboot the specified
        /// instance(s). The operation
        /// will succeed if the instances are valid
        /// and belong to the user.
        /// Requests to reboot terminated instances are ignored.
        /// </remarks>
        RebootInstancesResponse RebootInstances(RebootInstancesRequest request);

        /// <summary>
        /// Register Image 
        /// </summary>
        /// <param name="request">Register Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Register Image  Response from the service</returns>
        /// <remarks>
        /// The RegisterImage operation registers an AMI with
        /// Amazon EC2. Images must be
        /// registered before they can be launched. For
        /// more information, see RunInstances.
        /// Each AMI is associated with an
        /// unique ID which is provided by the Amazon EC2
        /// service through the RegisterImage operation.
        /// During registration, Amazon EC2
        /// retrieves the specified image manifest from
        /// Amazon S3 and verifies that the image
        /// is owned by the user registering the image.
        /// The image manifest is retrieved once and stored within the Amazon EC2.
        /// Any modifications to an image in Amazon S3 invalidates this
        /// registration. If you make changes to an image, deregister the
        /// previous image and register the new
        /// image. For more information, see DeregisterImage.
        /// </remarks>
        RegisterImageResponse RegisterImage(RegisterImageRequest request);

        /// <summary>
        /// Release Address 
        /// </summary>
        /// <param name="request">Release Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Release Address  Response from the service</returns>
        /// <remarks>
        /// The ReleaseAddress operation releases an elastic
        /// IP address associated with your account.
        /// Note:
        /// Releasing an IP address
        /// automatically disassociates it from any instance with
        /// which it is associated. For more information, see
        /// DisassociateAddress.
        /// Important:
        /// After releasing an elastic IP address, it is released to the IP
        /// address pool and might no longer be available to your account. Make
        /// sure to update your DNS records and any servers or devices that
        /// communicate with the address.
        /// If you run this operation on an elastic
        /// IP address that is already released,
        /// the address might be assigned to
        /// another account which will cause
        /// Amazon EC2 to return an error.
        /// </remarks>
        ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request);

        /// <summary>
        /// Reset Snapshot Attribute 
        /// </summary>
        /// <param name="request">Reset Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Snapshot Attribute  Response from the service</returns>
        /// <remarks>
        /// Resets permission settings for the specified
        /// snapshot.
        /// </remarks>
        ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request);

        /// <summary>
        /// Reset Image Attribute 
        /// </summary>
        /// <param name="request">Reset Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Image Attribute  Response from the service</returns>
        /// <remarks>
        /// The ResetImageAttribute operation resets an
        /// attribute of an AMI to its default value.
        /// Note:
        /// The productCodes
        /// attribute cannot be reset.
        /// </remarks>
        ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request);

        /// <summary>
        /// Revoke Security Group Ingress 
        /// </summary>
        /// <param name="request">Revoke Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// The RevokeSecurityGroupIngress operation revokes
        /// permissions from a security
        /// group. The permissions used to revoke must
        /// be specified using the same values
        /// used to grant the permissions.
        /// Permissions are specified by IP protocol (TCP, UDP, or ICMP), the
        /// source of the request (by IP range or an Amazon EC2 user-group pair),
        /// the source and destination port ranges (for TCP and UDP), and the ICMP
        /// codes and types (for ICMP).
        /// Permission changes are quickly propagated
        /// to instances within the security
        /// group. However, depending on the
        /// number of instances in the group, a
        /// small delay is might occur, .
        /// When revoking a user/group pair permission, GroupName,
        /// SourceSecurityGroupName
        /// and SourceSecurityGroupOwnerId must be
        /// specified. When authorizing a
        /// CIDR IP permission, GroupName,
        /// IpProtocol, FromPort, ToPort and CidrIp must be
        /// specified. Mixing these two types of parameters is not allowed.
        /// </remarks>
        RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);

        /// <summary>
        /// Run Instances 
        /// </summary>
        /// <param name="request">Run Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Run Instances  Response from the service</returns>
        /// <remarks>
        /// The RunInstances operation launches a specified
        /// number of instances.
        /// If Amazon EC2 cannot launch the minimum number
        /// AMIs you request, no instances
        /// launch. If there is insufficient
        /// capacity to launch the maximum number of AMIs
        /// you request, Amazon EC2
        /// launches as many as possible to satisfy the
        /// requested maximum values.
        /// Every instance is launched in a security group. If you do not
        /// specify a security group at launch, the instances start in your
        /// default security group. For more information on creating security
        /// groups, see CreateSecurityGroup.
        /// An optional instance type can be
        /// specified. For information about
        /// instance types, see Instance Types.
        /// You can provide an optional key pair ID for each image in the launch
        /// request (for more information, see CreateKeyPair). All instances that
        /// are created from images that use this key pair will have access to the
        /// associated public key at boot. You can use this key to provide secure
        /// access to an instance of an image on a per-instance basis. Amazon EC2
        /// public images use this feature to provide secure access without passwords.
        /// Important:
        /// Launching public images without a key pair ID will leave them inaccessible.
        /// The public key material is made available to the instance at boot
        /// time by placing it in the openssh_id.pub file on a logical device that is exposed
        /// to the instance as /dev/sda2 (the ephemeral store). The format of this
        /// file is suitable for use as an entry within ~/.ssh/authorized_keys (the
        /// OpenSSH format). This can be done at boot (e.g., as part of rc.local)
        /// allowing for secure access without passwords.
        /// Optional user data can be provided in the launch request. All instances that
        /// collectively comprise the launch request have access to this data
        /// For more information, see Instance Metadata.
        /// Note:
        /// If any of the AMIs have a product code attached for which the user has
        /// not subscribed, the RunInstances call will fail.
        /// Important:
        /// We strongly recommend using
        /// the 2.6.18 Xen stock kernel with the
        /// c1.medium and c1.xlarge
        /// instances. Although the default Amazon EC2 kernels will work, the
        /// new kernels provide greater stability and performance for these
        /// instance types. For more information about kernels, see Kernels, RAM
        /// Disks, and Block Device Mappings.
        /// </remarks>
        RunInstancesResponse RunInstances(RunInstancesRequest request);

        /// <summary>
        /// Stop Instances 
        /// </summary>
        /// <param name="request">Stop Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Stop Instances  Response from the service</returns>
        /// <remarks>
        /// Stops an instance that uses an Amazon EBS volume
        /// as its root device. Instances that use Amazon EBS volumes as their
        /// root devices can be quickly stopped and started.
        /// When an instance is stopped, the compute resources are released and you
        /// are not billed for hourly
        /// instance usage. However, your root partition Amazon EBS
        /// volume remains, continues to persist your
        /// data, and you are charged for Amazon EBS volume usage. You can restart
        /// your instance at any time.
        /// </remarks>
        StopInstancesResponse StopInstances(StopInstancesRequest request);

        /// <summary>
        /// Start Instances 
        /// </summary>
        /// <param name="request">Start Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Start Instances  Response from the service</returns>
        /// <remarks>
        /// Starts an instance that uses an Amazon EBS volume as its root device.
        /// Instances that use Amazon EBS volumes as their root devices can be
        /// quickly stopped and started. When an instance is
        /// stopped, the compute resources are released and you
        /// are not billed for hourly instance usage. However, your root
        /// partition Amazon EBS volume remains, continues to persist your
        /// data, and you are charged for Amazon EBS volume usage. You can restart
        /// your instance at any time.
        /// </remarks>
        StartInstancesResponse StartInstances(StartInstancesRequest request);

        /// <summary>
        /// Modify Instance Attribute 
        /// </summary>
        /// <param name="request">Modify Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Modifies an attribute of an instance.
        /// </remarks>
        ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request);

        /// <summary>
        /// Reset Instance Attribute 
        /// </summary>
        /// <param name="request">Reset Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Resets an attribute of an instance to its default
        /// value.
        /// </remarks>
        ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request);

        /// <summary>
        /// Describe Instance Attribute 
        /// </summary>
        /// <param name="request">Describe Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instance Attribute  Response from the service</returns>
        /// <remarks>
        /// Returns information about an attribute of an
        /// instance. Only one attribute
        /// can be specified per call.
        /// </remarks>
        DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request);

        /// <summary>
        /// Terminate Instances 
        /// </summary>
        /// <param name="request">Terminate Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Terminate Instances  Response from the service</returns>
        /// <remarks>
        /// The TerminateInstances operation shuts down one
        /// or more instances. This
        /// operation is idempotent; if you terminate an
        /// instance more than
        /// once, each call
        /// will succeed.
        /// Terminated instances
        /// will remain visible after termination (approximately one hour).
        /// </remarks>
        TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request);

        /// <summary>
        /// Monitor Instances 
        /// </summary>
        /// <param name="request">Monitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Monitor Instances  Response from the service</returns>
        /// <remarks>
        /// Enables monitoring for a running instance.
        /// </remarks>
        MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request);

        /// <summary>
        /// Unmonitor Instances 
        /// </summary>
        /// <param name="request">Unmonitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Unmonitor Instances  Response from the service</returns>
        /// <remarks>
        /// Disables monitoring for a running instance.
        /// </remarks>
        UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request);

        /// <summary>
        /// Describe Vpn Connections 
        /// </summary>
        /// <param name="request">Describe Vpn Connections  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Connections  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPN connections.
        /// Important -
        /// We strongly recommend you use HTTPS when calling this operation because the
        /// response contains sensitive cryptographic information for configuring your customer gateway.
        /// You can filter the results to return information only about VPN connections
        /// that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending
        /// or available. You can specify multiple filters (e.g., the VPN connection is
        /// associated with a particular VPN gateway, and the gateway's state is
        /// pending or available). The result includes information for a particular
        /// VPN connection only if the VPN connection matches all your filters.
        /// If there's no match, no special message is returned; the response is
        /// simply empty.
        /// </remarks>
        DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request);

        /// <summary>
        /// Describe Subnets 
        /// </summary>
        /// <param name="request">Describe Subnets  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Subnets  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your subnets. You can filter the results to
        /// return information only about subnets that match criteria you specify.
        /// For example, you could ask to get information about a particular subnet
        /// (or all) only if the subnet's state is available. You can specify multiple
        /// filters (e.g., the subnet is in a particular VPC, and the subnet's state is
        /// available). The result includes information for a particular subnet only
        /// if the subnet matches all your filters. If there's no match, no special
        /// message is returned; the response is simply empty. The following table
        /// shows the available filters.
        /// </remarks>
        DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Detach Vpn Gateway 
        /// </summary>
        /// <param name="request">Detach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Detaches a VPN gateway from a VPC. You do this if you're planning to
        /// turn off the VPC and not use it anymore. You can confirm a VPN gateway
        /// has been completely detached from a VPC by describing the VPN gateway
        /// (any attachments to the VPN gateway are also described).
        /// You must wait for the attachment's state to switch to detached before you can
        /// delete the VPC or attach a different VPC to the VPN gateway.
        /// </remarks>
        DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request);

        /// <summary>
        /// Describe Vpcs 
        /// </summary>
        /// <param name="request">Describe Vpcs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpcs  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPCs. You can filter the results to return
        /// information only about VPCs that match criteria you specify. For example,
        /// you could ask to get information about a particular VPC or VPCs (or all your VPCs)
        /// only if the VPC's state is available. You can specify multiple filters (e.g.,
        /// the VPC uses one of several sets of DHCP options, and the VPC's state is available).
        /// The result includes information for a particular VPC only if the VPC
        /// matches all your filters. If there's no match, no special message is
        /// returned; the response is simply empty.
        /// </remarks>
        DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Delete Customer Gateway 
        /// </summary>
        /// <param name="request">Delete Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Customer Gateway  Response from the service</returns>
        /// <remarks>
        /// Deletes a customer gateway. You must delete the VPN connection before
        /// deleting the customer gateway.
        /// AWS might delete any customer gateway if you leave it inactive for an extended
        /// period of time (inactive means that there's no VPN connection in use with the
        /// customer gateway).
        /// </remarks>
        DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request);

        /// <summary>
        /// Attach Vpn Gateway 
        /// </summary>
        /// <param name="request">Attach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Attaches a VPN gateway to a VPC. This is the last step required to get your
        /// VPC fully connected to your data center before launching instances in it.
        /// For more information, go to Process for Using Amazon VPC in the Amazon Virtual
        /// Private Cloud Developer Guide.
        /// </remarks>
        AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request);

        /// <summary>
        /// Delete Dhcp Options 
        /// </summary>
        /// <param name="request">Delete Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Deletes a set of DHCP options that you specify. Amazon VPC returns an error if the
        /// set of options you specify is currently associated with a VPC. You can disassociate
        /// the set of options by associating either a new set of options or the default options with the VPC.
        /// </remarks>
        DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request);

        /// <summary>
        /// Delete Subnet 
        /// </summary>
        /// <param name="request">Delete Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Subnet  Response from the service</returns>
        /// <remarks>
        /// Deletes a subnet from a VPC. You must terminate all running instances in the
        /// subnet before deleting it, otherwise Amazon VPC returns an error.
        /// AWS might delete any subnet if you leave it inactive for an extended period
        /// of time (inactive means that there are no running Amazon EC2 instances in the subnet).
        /// </remarks>
        DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request);

        /// <summary>
        /// Create Vpc 
        /// </summary>
        /// <param name="request">Create Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpc  Response from the service</returns>
        /// <remarks>
        /// Creates a VPC with the CIDR block you specify. The smallest VPC you can create
        /// uses a /28 netmask (16 IP addresses), and the largest uses a /18 netmask
        /// (16,384 IP addresses). To help you decide how big to make your VPC, go
        /// to the topic about creating VPCs  in the Amazon Virtual Private Cloud
        /// Developer Guide.
        /// By default, each instance you launch in the VPC has the default DHCP options
        /// (the standard EC2 host name, no domain name, no DNS server, no NTP server, and
        /// no NetBIOS server or node type).
        /// AWS might delete any VPC that you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon EC2
        /// instances in the VPC).
        /// </remarks>
        CreateVpcResponse CreateVpc(CreateVpcRequest request);

        /// <summary>
        /// Create Customer Gateway 
        /// </summary>
        /// <param name="request">Create Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Customer Gateway  Response from the service</returns>
        /// <remarks>
        /// Provides information to AWS about your customer gateway device.
        /// The customer gateway is the appliance at your end of the VPN connection
        /// (compared to the VPN gateway, which is the device at the AWS side of the VPN
        /// connection). AWS might delete any customer gateway that you create with this
        /// operation if you leave it inactive for an extended period of time (inactive means
        /// that there's no VPN connection in use with the customer gateway).
        /// You must provide the Internet-routable IP address of the customer gateway's external
        /// interface. The IP address must be static and can't be behind a device performing
        /// network address translation (NAT).
        /// You must also provide the device's Border Gateway Protocol (BGP) Autonomous
        /// System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534 range).
        /// For more information about ASNs, go to the Wikipedia article -
        /// http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29.
        /// </remarks>
        CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request);

        /// <summary>
        /// Create Vpn Gateway 
        /// </summary>
        /// <param name="request">Create Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Creates a new VPN gateway. A VPN gateway is the VPC-side endpoint for
        /// your VPN connection. You can create a VPN gateway before creating the VPC
        /// itself. AWS might delete any VPN gateway that you create with this operation
        /// if you leave it inactive for an extended period of time (inactive means
        /// that there's no VPN connection in use with the VPN gateway).
        /// </remarks>
        CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request);

        /// <summary>
        /// Delete Vpc 
        /// </summary>
        /// <param name="request">Delete Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpc  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPC. You must terminate all running instances and delete all
        /// subnets before deleting the VPC, otherwise Amazon VPC returns an error.
        /// AWS might delete any VPC if you leave it inactive for an extended period of time
        /// (inactive means that there are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        DeleteVpcResponse DeleteVpc(DeleteVpcRequest request);

        /// <summary>
        /// Associate Dhcp Options 
        /// </summary>
        /// <param name="request">Associate Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Associates a set of DHCP options (that you've previously created) with the specified VPC.
        /// Or, associates the default DHCP options with the VPC. The default set consists of the standard
        /// EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or node type.
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. For more information about the supported DHCP
        /// options and using them with Amazon VPC, go to Using DHCP Options in the Amazon Virtual
        /// Private Cloud Developer Guide.
        /// </remarks>
        AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request);

        /// <summary>
        /// Describe Vpn Gateways 
        /// </summary>
        /// <param name="request">Describe Vpn Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Gateways  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your VPN gateways. You can filter the results to return
        /// information only about VPN gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the
        /// VPN gateway is in a particular Availability Zone and the gateway's state is pending or
        /// available). The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty.
        /// </remarks>
        DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request);

        /// <summary>
        /// Create Subnet 
        /// </summary>
        /// <param name="request">Create Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Subnet  Response from the service</returns>
        /// <remarks>
        /// Creates a subnet in an existing VPC. You can create up to 20 subnets in a VPC.
        /// If you add more than one subnet to a VPC, they're set up in a star topology with
        /// a logical router in the middle. If you feel you need more than 20 subnets, you can
        /// request more by going to http://aws.amazon.com/contact-us/vpc-request/.
        /// When you create each subnet, you provide the VPC ID and the CIDR block you
        /// want for the subnet. Once you create a subnet, you can't change its CIDR block.
        /// The subnet's CIDR block can be the same as the VPC's CIDR block (assuming you
        /// want only a single subnet in the VPC), or a subset of the VPC's CIDR block.
        /// If you create more than one subnet in a VPC, the subnets' CIDR blocks must not overlap.
        /// The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP addresses),
        /// and the largest uses a /18 netmask (16,384 IP addresses).
        /// Important -
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
        /// They're not available for use.
        /// AWS might delete any subnet you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon EC2
        /// instances in the subnet).
        /// </remarks>
        CreateSubnetResponse CreateSubnet(CreateSubnetRequest request);

        /// <summary>
        /// Delete Vpn Connection 
        /// </summary>
        /// <param name="request">Delete Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Connection  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPN connection. Use this if you want to delete a VPC and
        /// all its associated components. Another reason to use this operation
        /// is if you believe the tunnel credentials for your VPN connection have
        /// been compromised. In that situation, you can delete the VPN connection
        /// and create a new one that has new keys, without needing to delete the
        /// VPC or VPN gateway. If you create a new VPN connection, you must
        /// reconfigure the customer gateway using the new configuration
        /// information returned with the new VPN connection ID.
        /// If you're deleting the VPC and all its associated parts, we recommend you
        /// detach the VPN gateway from the VPC and delete the VPC before deleting
        /// the VPN connection.
        /// </remarks>
        DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);

        /// <summary>
        /// Delete Vpn Gateway 
        /// </summary>
        /// <param name="request">Delete Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Gateway  Response from the service</returns>
        /// <remarks>
        /// Deletes a VPN gateway. Use this when you want to delete a VPC and all
        /// its associated components because you no longer need them. We recommend
        /// that before you delete a VPN gateway, you detach it from the VPC and
        /// delete the VPN connection. Note that you don't need to delete the VPN
        /// gateway if you just want to delete and re-create the VPN connection
        /// between your VPC and data center.
        /// AWS might delete any VPN gateway if you leave it inactive for an extended period of time
        /// (inactive means that there's no VPN connection in use with the VPN gateway).
        /// </remarks>
        DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);

        /// <summary>
        /// Describe Customer Gateways 
        /// </summary>
        /// <param name="request">Describe Customer Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Customer Gateways  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your customer gateways. You can filter the results to return
        /// information only about customer gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular customer gateway (or all) only if
        /// the gateway's state is pending or available. You can specify multiple filters (e.g.,
        /// the customer gateway has a particular IP address for the Internet-routable external
        /// interface, and the gateway's state is pending or available). The result includes
        /// information for a particular customer gateway only if the gateway matches all  your
        /// filters. If there's no match, no special message is returned; the response is simply empty.
        /// </remarks>
        DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request);

        /// <summary>
        /// Create Vpn Connection 
        /// </summary>
        /// <param name="request">Create Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Connection  Response from the service</returns>
        /// <remarks>
        /// Creates a new VPN connection between an existing VPN gateway and customer
        /// gateway. The only supported connection type is ipsec.1.
        /// The response includes information that you need to configure your customer gateway,
        /// in XML format. We recommend you use the command line version of this operation
        /// (ec2-create-vpn-connection), which lets you get the configuration information
        /// formatted in a friendlier way. For information about the command, go to
        /// ec2-create-vpn-connection in the Amazon Virtual Private Cloud Command Line Reference.
        /// Important -
        /// We strongly recommend you use HTTPS when calling this operation because
        /// the response contains sensitive cryptographic information for configuring
        /// your customer gateway.
        /// If you decide to shut down your VPN connection for any reason and then create a new
        /// one, you must re-configure your customer gateway with the new information
        /// returned from this call.
        /// </remarks>
        CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request);

        /// <summary>
        /// Describe Dhcp Options 
        /// </summary>
        /// <param name="request">Describe Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Gives you information about one or more sets of DHCP options. You can specify
        /// one or more DHCP options set IDs, or no IDs (to describe all your sets of DHCP options).
        /// The returned information consists of:
        /// - The DHCP options set ID
        /// - The options
        /// </remarks>
        DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Create Dhcp Options 
        /// </summary>
        /// <param name="request">Create Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Dhcp Options  Response from the service</returns>
        /// <remarks>
        /// Creates a set of DHCP options that you can then associate with one or more VPCs,
        /// causing all existing and new instances that you launch in those VPCs to use the
        /// set of DHCP options. The following table lists the individual DHCP options you can
        /// specify. For more information about the options, go to RFC 2132 - http://www.ietf.org/rfc/rfc2132.txt
        /// </remarks>
        CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request);

        /// <summary>
        /// Request Spot Instances 
        /// </summary>
        /// <param name="request">Request Spot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Request Spot Instances  Response from the service</returns>
        /// <remarks>
        /// Creates a Spot Instance request. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request);

        /// <summary>
        /// Describe Spot Instance Requests 
        /// </summary>
        /// <param name="request">Describe Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Instance Requests  Response from the service</returns>
        /// <remarks>
        /// Describes Spot Instance requests. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Cancel Spot Instance Requests 
        /// </summary>
        /// <param name="request">Cancel Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Spot Instance Requests  Response from the service</returns>
        /// <remarks>
        /// Cancels Spot Instance requests. Spot Instances are instances that automatically launch when your
        /// request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request);

        /// <summary>
        /// Describe Spot Price History 
        /// </summary>
        /// <param name="request">Describe Spot Price History  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Price History  Response from the service</returns>
        /// <remarks>
        /// Describes historical pricing for Spot Instances. Spot Instances are instances that automatically launch
        /// when your request price exceeds the Spot Price that Amazon EC2 periodically calculates.
        /// </remarks>
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Create Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Create Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Creates the data feed for Spot Instances, enabling you to view Spot Instance usage logs. You can
        /// create one data feed per account.
        /// </remarks>
        CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Describe Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Describe Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Describes the data feed for Spot Instances.
        /// </remarks>
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Delete Spot Datafeed Subscription 
        /// </summary>
        /// <param name="request">Delete Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Spot Datafeed Subscription  Response from the service</returns>
        /// <remarks>
        /// Deletes the data feed for Spot Instances.
        /// </remarks>
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Cancel Conversion Task 
        /// </summary>
        /// <param name="request">Cancel Conversion Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Conversion Task  Response from the service</returns>
        /// <remarks>
        /// Cancels an active conversion task. The task can be the import of an instance or volume. The command removes all artifacts of
        /// the conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final disk image, the command fails and returns an exception.
        /// </remarks>
        CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request);

        /// <summary>
        /// Describe Conversion Tasks 
        /// </summary>
        /// <param name="request">Describe Conversion Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Conversion Tasks  Response from the service</returns>
        /// <remarks>
        /// Describes your conversion tasks. For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
        /// </remarks>
        DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request);

        /// <summary>
        /// Import Instance 
        /// </summary>
        /// <param name="request">Import Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Instance  Response from the service</returns>
        /// <remarks>
        /// Creates a new import instance task using metadata from the specified disk image. For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
        /// </remarks>
        ImportInstanceResponse ImportInstance(ImportInstanceRequest request);

        /// <summary>
        /// Import Volume 
        /// </summary>
        /// <param name="request">Import Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Volume  Response from the service</returns>
        /// <remarks>
        /// Creates a new import volume task using metadata from the specified disk image. For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
        /// </remarks>
        ImportVolumeResponse ImportVolume(ImportVolumeRequest request);

        /// <summary>
        /// Authorize Security Group Egress 
        /// </summary>
        /// <param name="request">Authorize Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Egress  Response from the service</returns>
        /// <remarks>
        /// This action applies only to security groups in a VPC; it's not supported for standard (EC2) security groups.
        /// For information about Amazon Virtual Private Cloud and VPC security groups, go to the Amazon Virtual
        /// Private Cloud User Guide.
        /// The action adds one or more egress rules to a VPC security group. Specifically, this permits instances
        /// in a security group to send traffic to either one or more destination CIDR IP address ranges, or to one or
        /// more destination security groups in the same VPC.
        /// Each rule consists of the protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP
        /// and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you
        /// must also specify the ICMP type and code.You can use -1 as a wildcard for the ICMP type or code.
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// Adding hundreds of rules to a security group might cause problems when you access the instance.
        /// We recommend you condense your rules as much as possible.
        /// </remarks>
        AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request);

        /// <summary>
        /// Revoke Security Group Egress 
        /// </summary>
        /// <param name="request">Revoke Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Egress  Response from the service</returns>
        /// <remarks>
        /// This action applies only to security groups in a VPC. It doesn't work with standard (EC2) security groups.
        /// For information about Amazon Virtual Private Cloud and VPC security groups, go to the Amazon Virtual
        /// Private Cloud User Guide.
        /// The action removes one or more egress rules from a VPC security group. The values that you specify in
        /// the revoke request (e.g., ports, etc.) must match the existing rule's values in order for the rule to be
        /// revoked.
        /// Each rule consists of the protocol, and the CIDR range or destination security group. For the TCP and
        /// UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you
        /// must also specify the ICMP type and code.
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// </remarks>
        RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);

        /// <summary>
        /// Create Internet Gateway 
        /// </summary>
        /// <param name="request">Create Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Internet Gateway  Response from the service</returns>
        /// <remarks>
        /// Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach
        /// it to a VPC using AttachInternetGateway. For more information about your VPC and Internet gateway,
        /// go to Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request);

        /// <summary>
        /// Describe Internet Gateways 
        /// </summary>
        /// <param name="request">Describe Internet Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Internet Gateways  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your Internet gateways.You can filter the results to return information only
        /// about Internet gateways that match criteria you specify. For example, you could get information only
        /// about gateways with particular tags. The Internet gateway must match at least one of the specified values
        /// for it to be included in the results.
        /// You can specify multiple filters (e.g., the Internet gateway is attached to a particular VPC and is tagged
        /// with a particular value). The result includes information for a particular Internet gateway only if the gateway
        /// matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// You can use wildcards with the filter values: * matches zero or more characters, and ? matches exactly
        /// one character.You can escape special characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Delete Internet Gateway 
        /// </summary>
        /// <param name="request">Delete Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Internet Gateway  Response from the service</returns>
        /// <remarks>
        /// Deletes an Internet gateway from your AWS account. The gateway must not be attached to a VPC. For
        /// more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request);

        /// <summary>
        /// Attach Internet Gateway 
        /// </summary>
        /// <param name="request">Attach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Internet Gateway  Response from the service</returns>
        /// <remarks>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For
        /// more information about your VPC and Internet gateway, go to the Amazon Virtual Private Cloud User
        /// Guide.
        /// </remarks>
        AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request);

        /// <summary>
        /// Detach Internet Gateway 
        /// </summary>
        /// <param name="request">Detach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Internet Gateway  Response from the service</returns>
        /// <remarks>
        /// Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC.The
        /// VPC must not contain any running instances with elastic IP addresses. For more information about your
        /// VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// For more information about Amazon Virtual Private Cloud and Internet gateways, go to the Amazon Virtual
        /// Private Cloud User Guide.
        /// </remarks>
        DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request);

        /// <summary>
        /// Create Route Table 
        /// </summary>
        /// <param name="request">Create Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route Table  Response from the service</returns>
        /// <remarks>
        /// Creates a new route table within a VPC. After you create a new route table, you can add routes and
        /// associate the table with a subnet. For more information about route tables, go to Route Tables in the
        /// Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request);

        /// <summary>
        /// Describe Route Tables 
        /// </summary>
        /// <param name="request">Describe Route Tables  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Route Tables  Response from the service</returns>
        /// <remarks>
        /// Gives you information about your route tables.You can filter the results to return information only about
        /// tables that match criteria you specify. For example, you could get information only about a table associated
        /// with a particular subnet.You can specify multiple values for the filter. The table must match at least one
        /// of the specified values for it to be included in the results.
        /// You can specify multiple filters (e.g., the table has a particular route, and is associated with a particular
        /// subnet). The result includes information for a particular table only if it matches all your filters. If there's
        /// no match, no special message is returned; the response is simply empty.
        /// You can use wildcards with the filter values: * matches zero or more characters, and ? matches exactly
        /// one character.You can escape special characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Delete Route Table 
        /// </summary>
        /// <param name="request">Delete Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route Table  Response from the service</returns>
        /// <remarks>
        /// Deletes a route table from a VPC. The route table must not be associated with a subnet.You can't delete
        /// the main route table. For more information about route tables, go to Route Tables in the Amazon Virtual
        /// Private Cloud User Guide.
        /// </remarks>
        DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request);

        /// <summary>
        /// Associate Route Table 
        /// </summary>
        /// <param name="request">Associate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Route Table  Response from the service</returns>
        /// <remarks>
        /// Associates a subnet with a route table. The subnet and route table must be in the same VPC. This
        /// association causes traffic originating from the subnet to be routed according to the routes in the route
        /// table. The action returns an association ID, which you need if you want to disassociate the route table
        /// from the subnet later. A route table can be associated with multiple subnets.
        /// For more information about route tables, go to Route Tables in the Amazon Virtual Private Cloud User
        /// Guide.
        /// </remarks>
        AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request);

        /// <summary>
        /// Replace Route Table Association 
        /// </summary>
        /// <param name="request">Replace Route Table Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route Table Association  Response from the service</returns>
        /// <remarks>
        /// Changes the route table associated with a given subnet in a VPC. After you execute this action, the subnet
        /// uses the routes in the new route table it's associated with. For more information about route tables, go
        /// to Route Tables in the Amazon Virtual Private Cloud User Guide.
        /// You can also use this to change which table is the main route table in the VPC.You just specify the main
        /// route table's association ID and the route table that you want to be the new main route table.
        /// </remarks>
        ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request);

        /// <summary>
        /// Disassociate Route Table 
        /// </summary>
        /// <param name="request">Disassociate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Route Table  Response from the service</returns>
        /// <remarks>
        /// Disassociates a subnet from a route table.
        /// After you perform this action, the subnet no longer uses the routes in the route table. Instead it uses the
        /// routes in the VPC's main route table. For more information about route tables, go to Route Tables in the
        /// Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request);

        /// <summary>
        /// Create Route 
        /// </summary>
        /// <param name="request">Create Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route  Response from the service</returns>
        /// <remarks>
        /// Creates a new route in a route table within a VPC. The route's target can be either a gateway attached
        /// to the VPC or a NAT instance in the VPC.
        /// When determining how to route traffic, we use the route with the most specific match. For example, let's
        /// say the traffic is destined for 192.0.2.3, and the route table includes the following two routes:
        /// 192.0.2.0/24 (goes to some target A)
        /// 192.0.2.0/28 (goes to some target B)
        /// Both routes apply to the traffic destined for 192.0.2.3. However, the second route in the list is more specific,
        /// so we use that route to determine where to target the traffic.
        /// For more information about route tables, go to Route Tables in the Amazon Virtual Private Cloud User
        /// Guide.
        /// </remarks>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Replace Route 
        /// </summary>
        /// <param name="request">Replace Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route  Response from the service</returns>
        /// <remarks>
        /// Replaces an existing route within a route table in a VPC. For more information about route tables, go to
        /// Route Tables in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request);

        /// <summary>
        /// Delete Route 
        /// </summary>
        /// <param name="request">Delete Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route  Response from the service</returns>
        /// <remarks>
        /// Deletes a route from a route table in a VPC. For more information about route tables, go to Route Tables
        /// in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Create Network Acl 
        /// </summary>
        /// <param name="request">Create Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl  Response from the service</returns>
        /// <remarks>
        /// Creates a new network ACL in a VPC. Network ACLs provide an optional layer of security (on top of
        /// security groups) for the instances in your VPC. For more information about network ACLs, go to Network
        /// ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request);

        /// <summary>
        /// Describe Network Acls 
        /// </summary>
        /// <param name="request">Describe Network Acls  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Acls  Response from the service</returns>
        /// <remarks>
        /// Gives you information about the network ACLs in your VPC.You can filter the results to return information
        /// only about ACLs that match criteria you specify. For example, you could get information only the ACL
        /// associated with a particular subnet. The ACL must match at least one of the specified values for it to be
        /// included in the results.
        /// You can specify multiple filters (e.g., the ACL is associated with a particular subnet and has an egress
        /// entry that denies traffic to a particular port). The result includes information for a particular ACL only if it
        /// matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// You can use wildcards with the filter values: * matches zero or more characters, and ? matches exactly
        /// one character.You can escape special characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Delete Network Acl 
        /// </summary>
        /// <param name="request">Delete Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl  Response from the service</returns>
        /// <remarks>
        /// Deletes a network ACL from a VPC. The ACL must not have any subnets associated with it.You can't
        /// delete the default network ACL. For more information about network ACLs, go to Network ACLs in the
        /// Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request);

        /// <summary>
        /// Replace Network Acl Association 
        /// </summary>
        /// <param name="request">Replace Network Acl Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Association  Response from the service</returns>
        /// <remarks>
        /// Changes which network ACL a subnet is associated with. By default when you create a subnet, it's
        /// automatically associated with the default network ACL. For more information about network ACLs, go to
        /// Network ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request);

        /// <summary>
        /// Create Network Acl Entry 
        /// </summary>
        /// <param name="request">Create Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl Entry  Response from the service</returns>
        /// <remarks>
        /// Creates an entry (i.e., rule) in a network ACL with a rule number you specify. Each network ACL has a
        /// set of numbered ingress rules and a separate set of numbered egress rules. When determining whether
        /// a packet should be allowed in or out of a subnet associated with the ACL, Amazon VPC processes the
        /// entries in the ACL according to the rule numbers, in ascending order.
        /// We recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number
        /// them sequentially (101, 102, 103, etc.). This allows you to easily add a new rule between existing
        /// ones without having to renumber the rules.
        /// After you add an entry, you can't modify it; you must either replace it, or create a new entry and delete
        /// the old one.
        /// For more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User
        /// Guide.
        /// </remarks>
        CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request);

        /// <summary>
        /// Replace Network Acl Entry 
        /// </summary>
        /// <param name="request">Replace Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Entry  Response from the service</returns>
        /// <remarks>
        /// Replaces an entry (i.e., rule) in a network ACL. For more information about network ACLs, go to Network
        /// ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request);

        /// <summary>
        /// Delete Network Acl Entry 
        /// </summary>
        /// <param name="request">Delete Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl Entry  Response from the service</returns>
        /// <remarks>
        /// Deletes an ingress or egress entry (i.e., rule) from a network ACL. For more information about network
        /// ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request);

    }
}
