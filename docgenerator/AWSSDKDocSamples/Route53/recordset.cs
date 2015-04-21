using System;
using System.Collections.Generic;
using System.Threading;

using Amazon;
using Amazon.Route53;
using Amazon.Route53.Model;

namespace AWSSDKDocSamples.Route53
{
  //Create a hosted zone and add a basic record set to it
  class route53samples : ISample
  {
    public static void Route53CreateAdd(string[] args)
    {
      #region Route53CreateAdd
      string domainName = "www.example.org";

      IAmazonRoute53 route53Client = new AmazonRoute53Client();

      CreateHostedZoneRequest zoneRequest = new CreateHostedZoneRequest
      {
        Name = domainName,
        CallerReference = "my_change_request"
      };

      CreateHostedZoneResponse zoneResponse = route53Client.CreateHostedZone(zoneRequest);

      ResourceRecordSet recordSet = new ResourceRecordSet
      {
        Name = domainName,
        TTL = 60,
        Type = RRType.A,
        ResourceRecords = new List<ResourceRecord> { new ResourceRecord { Value = "192.0.2.235" } }
      };

      Change change1 = new Change
      {
        ResourceRecordSet = recordSet,
        Action = ChangeAction.CREATE
      };

      ChangeBatch changeBatch = new ChangeBatch
      {
        Changes = new List<Change> { change1 }
      };

      ChangeResourceRecordSetsRequest recordsetRequest = new ChangeResourceRecordSetsRequest
      {
        HostedZoneId = zoneResponse.HostedZone.Id,
        ChangeBatch = changeBatch
      };

      ChangeResourceRecordSetsResponse recordsetResponse = route53Client.ChangeResourceRecordSets(recordsetRequest);

      GetChangeRequest changeRequest = new GetChangeRequest
      {
        Id = recordsetResponse.ChangeInfo.Id
      };

      while (route53Client.GetChange(changeRequest).ChangeInfo.Status == ChangeStatus.PENDING)
      {
        Console.WriteLine("Change is pending.");
        Thread.Sleep(TimeSpan.FromSeconds(15));
      }
      #endregion

      Console.WriteLine("Change is complete.");
      Console.ReadKey();
    }
    #region ISample Members
    public virtual void Run()
    {

    }
    #endregion
  }
}