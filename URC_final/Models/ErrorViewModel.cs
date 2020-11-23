/**
*
Author:    Daniel Pak & Kyungyoon Kim
Date:      Sep 23th, 2020
Course:    CS 4540, University of Utah, School of Computing
Copyright: CS 4540, Kyungyoon Kim and Daniel Pak - This work may not be copied for use in Academic Coursework.

We, Kyungyoon Kim and Daniel Pak, certify that I wrote this code from scratch and did not copy it in part or whole from
another source.  Any references used in the completion of the assignment are cited in my README file.

File Contents

ErrorViewModel

*/

namespace URC_final.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}